using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using System.ComponentModel;



namespace App7.ViewModel
{
    // INotifyPropertyChanged 인터페이스는 클라이언트(뷰의 컨트롤)에 속성값의 변경을
    // 통지를 하기위해 사용, 사용자가 버튼을 클릭했을때 변경된 값이 라벨 컨트롤에 반영된다.
    public class EmpViewModel : INotifyPropertyChanged
    {
        public string Ename { get; set; }
        private string _Message { get; set; }
        public string Message {
            get { return _Message; }
            set { _Message = value; OnPropertyChanged(); }
        }

        public Command Introduce {
            get {
                return new Command(() => { Message = "My name is " + Ename; });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
