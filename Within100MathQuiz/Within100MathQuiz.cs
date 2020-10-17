using System;
using System.Media;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using Within100MathQuiz.Properties;

namespace Within100MathQuiz
{
    public partial class Quiz : Form
    {
        private readonly Random _random = new Random();
        private int _addNumLeft, _addNumRight;
        private int _minusNumLeft, _minusNumRight;
        private int _multiplyNumLeft, _multiplyNumRight;
        private int _divideNumLeft, _divideNumRight;

        enum Status
        {
            Idle = 0,
            Quizing = 1
        }

        private Status status;
        //难度
        private int _level = 1;
        //剩余时间
        private int _timeLeft = 1;
        //分数
        private int _score;

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case Status.Idle:
                {
                    StartQuiz();
                    //初始化文本
                    Sum.Text = "0";
                    Difference.Text = "0";
                    Product.Text = "0";
                    Quotient.Text = "0";
                    ButtonStart.Text = @"要交卷了？";
                    status = Status.Quizing;
                    break;
                }
                case Status.Quizing:
                {
                    if(CheckCorrectness())
                    {
                        var str = new StringBuilder();
                        switch (_score)
                        {
                            case 0:
                                str.Append("呵呵，");
                                break;
                            case 25:
                                str.Append("你只有");
                                break;
                            case 50:
                                str.Append("勉强有个");
                                break;
                            case 75:
                                str.Append("竟然有");
                                break;
                            case 100:
                                str.Append("真不错");
                                break;
                        }
                        str.Append(_score);
                        status = Status.Idle;
                        MessageBox.Show(str.ToString());
                        ButtonStart.Text = @"开始测验？";
                    }
                    break;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= 1;
                LabelTimer.Text = _timeLeft.ToString() + @"秒";
            }
            else
            {
                timer1.Stop();
                LabelTimer.Text = @"Time's up!";
                //播放音乐羞辱小朋友
                //SoundPlayer player = new SoundPlayer(@"E:\VS2019projects\calculator\Within100MathQuiz\Within100MathQuiz\assets\哈哈哈多捞啊.wav");
                //player.Play();
                MessageBox.Show(@"时间到了还不交卷？0分！", @"Time's up!");
                status = Status.Idle;
                Sum.Text = (_addNumLeft + _addNumRight).ToString();
                Difference.Text = (_minusNumLeft - _minusNumRight).ToString();
                Product.Text = (_multiplyNumLeft * _multiplyNumRight).ToString();
                Quotient.Text = (_divideNumLeft / _divideNumRight).ToString();
                ButtonStart.Enabled = true;
            }
        }

        private void StartQuiz()
        {
            //填充题目
            _addNumLeft = _random.Next( 50 * _level + 1);
            LabelLeftPlusNum.Text = _addNumLeft.ToString();
            _addNumRight = _random.Next(50 * _level + 1);
            LabelRightPlusNum.Text = _addNumRight.ToString();
            
            _minusNumLeft = _random.Next(50 * _level + 1, 100 * _level + 1);
            LabelLeftMinusNum.Text = _minusNumLeft.ToString();
            _minusNumRight = _random.Next(50 * _level + 1);
            LabelRightMinusNum.Text = _minusNumRight.ToString();
            
            _multiplyNumLeft = _random.Next(50 * _level + 1);
            LabelLeftMultiplyNum.Text = _multiplyNumLeft.ToString();
            _multiplyNumRight = _random.Next(50 * _level + 1);
            LabelRightMultiplyNum.Text = _multiplyNumRight.ToString();
            
            _divideNumRight = _random.Next(1, 51);
            LabelRightDivideNum.Text = _divideNumRight.ToString();
            _divideNumLeft = _random.Next(51) * _divideNumRight;
            LabelLeftDivideNum.Text = _divideNumLeft.ToString();
            //根据难度适当上调时间
            _timeLeft += _level * 5;
            //初始化计时器
            LabelTimer.Text = _timeLeft.ToString()+@"秒";
            timer1.Enabled = true;

        }

        private void SetLevel(int level)
        {
            this._level = level;
        }
        public Quiz()
        {
            InitializeComponent();
        }
        //返回真只是表示可以结束了，并不是说全部正确
        //只有格式错误才会返回false，允许重填
        private bool CheckCorrectness()
        {
            try
            {
                int sum = Int32.Parse(Sum.Text);
                int difference = Int32.Parse(Difference.Text);
                int product = Int32.Parse(Product.Text);
                int quotient = Int32.Parse(Quotient.Text);

                if (sum == _addNumLeft + _addNumRight)
                    _score += 25;
                if (difference == _minusNumLeft + _minusNumRight)
                    _score += 25;
                if (sum == _multiplyNumLeft + _multiplyNumRight)
                    _score += 25;
                if (sum == _divideNumLeft + _divideNumRight)
                    _score += 25;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
                //播放音乐羞辱小朋友
                SoundPlayer player = new SoundPlayer(Within100MathQuiz.Properties.Resources.哈哈哈多捞啊);
                player.Play();
                MessageBox.Show(@"空着也敢交？", @"格式不对！");
                return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
                //播放音乐羞辱小朋友
                SoundPlayer player = new SoundPlayer(Within100MathQuiz.Properties.Resources.哈哈哈多捞啊);
                player.Play();
                MessageBox.Show(@"你填的都是什么东西？", @"格式不对！");
                return false;
            }
            return true;
        }

    }
}
