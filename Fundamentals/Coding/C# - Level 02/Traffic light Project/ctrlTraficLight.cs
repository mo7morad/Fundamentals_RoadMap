using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trafik_light_Project.Properties;

namespace trafik_light_Project
{
    public partial class ctrlTraficLight : UserControl
    {
        public enum LightEnum { Red = 0, Orange = 1, Green = 2 }
        private LightEnum _CurrentLight = LightEnum.Red;


        public class TraficLightEventArgs:EventArgs
        {
            public LightEnum CurrentLight { get; }
            public int LightDuration { get; } 

            public   TraficLightEventArgs (LightEnum CurrentLight,int LightDuration)
            {
                this.CurrentLight = CurrentLight;
                this.LightDuration = LightDuration; 
            }
        }

       
        public event EventHandler <TraficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs( LightEnum.Red,_RedTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs  e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> RedLightOff;

        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TraficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }

        protected virtual void RaiseRedLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(LightEnum.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> GreenLightOff;
        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TraficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseGreenLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public LightEnum CurrentLight  
        { 
            get 
            {
                return _CurrentLight;
            }
        
            set
            {
                _CurrentLight=value;

                switch (_CurrentLight)
                {
                    case LightEnum.Red:
                        pbLight.Image= Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                      //  _CurrentCountDownValue = RedTime;
                      //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                    case LightEnum.Orange:
                        pbLight.Image= Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                       // _CurrentCountDownValue = OrangeTime;
                       // lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                    case LightEnum.Green:
                        pbLight.Image= Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                       // _CurrentCountDownValue = GreenTime;
                      //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                   default:
                        lblCountDown.ForeColor = Color.Red;
                       // _CurrentCountDownValue = RedTime;
                      //  lblCountDown.Text = _CurrentCountDownValue.ToString();
                        break;
                }

            }
        
        }

        private int _RedTime = 10;
        private int _OrangeTime = 3;
        private int _GreenTime = 10;
       
        private int  _CurrentCountDownValue;

        public int RedTime
        {
            get
            {
                return _RedTime;
            }
            set
            {
                _RedTime = value;
               
            }
        }

        public int OrangeTime
        {
            get
            {
                return _OrangeTime;
            }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return _GreenTime;
            }
            set
            {
                _GreenTime = value;
            }
        }

        public int GetCurrentTime()
        { 
            
            switch (_CurrentLight)
            {
                case LightEnum.Orange:
                    return OrangeTime;

                case LightEnum.Green:
                    return GreenTime;
                case LightEnum.Red:
                    return RedTime;
                    default: return RedTime;
            }

          
        
        }


        public void Start ()
        {
            _CurrentCountDownValue = GetCurrentTime();
            LightTimer.Start();
        
        }

        public void Stop()
        {
            LightTimer.Stop();

        }

        public ctrlTraficLight()
        {
            InitializeComponent();
        }

        private void LightTimer_Tick(object sender, EventArgs e)
        {

            lblCountDown.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue == 0)
            {
               // LightTimer.Stop();
                _ChangeLight();
              
            }
            else
            {
               
                
                --_CurrentCountDownValue;

            }
           
        }

        private LightEnum _LightAfterOrangeGreenOrRed;


        private void _ChangeLight()
        {
            switch (_CurrentLight)
            {
                case LightEnum.Red:
                    _LightAfterOrangeGreenOrRed = LightEnum.Green;
                    CurrentLight = LightEnum.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();

                    RaiseOrangeLightOn();
                
                    break;

                case LightEnum.Orange:
                    if (_LightAfterOrangeGreenOrRed == LightEnum.Green)
                    {
                        CurrentLight = LightEnum.Green;
                        _CurrentCountDownValue = GreenTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();

                        RaiseGreenLightOn();
             

                    }
                    else
                    {
                        CurrentLight = LightEnum.Red;
                        _CurrentCountDownValue = RedTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();

                 

                    }

                    break;

                case LightEnum.Green:
                    _LightAfterOrangeGreenOrRed = LightEnum.Red;
                  
                    CurrentLight = LightEnum.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                
                    break;

                default:
                    pbLight.Image = Resources.Red;
                    break;
            }


        }

    }
}
