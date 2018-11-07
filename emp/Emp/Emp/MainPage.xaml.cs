using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System.Net.Http;

// 자마린 앱에서 스프링프레임워크/스프링부트 RESTful기반 웹서비스 Call 실습, 
// JSON 파싱하기[웹서비스는 자바, 스프링으로 모바일 앱은 자마린으로!]

namespace Emp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //사원 전체 목록 출력
        private async void Button1_Click(object sender,
       System.EventArgs e)
        {
            /* 응답 JSON 형식
            * [{"empno":1001,"ename":"TopCredu","sal":6000,"job":"CLERK"},
            * {"empno":1002,"ename":"Jhon
           Denver","sal":7000,"job":"SALESMAN"},
            * {"empno":1003,"ename":"Karl 
           Luice","sal":8000,"job":"MANAGER"},
            * {"empno":1004,"ename":"Chanho
           Park","sal":7000,"job":"SALESMAN"},
            * {"empno":1005,"ename":"Phile
           Migalon","sal":8000,"job":"MANAGER"},
            * {"empno":1006,"ename":"Jhon
           Smith","sal":7500,"job":"SALESMAN"},
            *
           {"empno":1007,"ename":"OracleJavaCommunity","sal":6800,"job":"CLERK"},
            * {"empno":1008,"ename":"Ojc.Asia","sal":7200,"job":"CLERK"}]
            * */
            activityIndicator.IsVisible = true;
            string url = "http://192.168.0.214:8080/emp/all";
            // 네트워크 연결 상태 확인
            if (CrossConnectivity.Current.IsConnected)
            {
                var client = new HttpClient();
                var res = await client.GetAsync(url);
                string ResponseStr = await
               res.Content.ReadAsStringAsync();
                //EmpList empList = new EmpList();
                if (ResponseStr != "")
                {

                    // 웹서비스에서 리턴하는 JSON 형식을 EmpList 형식으로 변환
                listView.ItemsSource = JsonConvert.DeserializeObject<List<Model.Emp>>(ResponseStr);
                }
                // 리스트뷰의 아이템소스로 emps 컬렉션을 할당 화면에 출력됨
                // listView.ItemsSource = empList.Emps;
            }
            else
            {
                await DisplayAlert("에러!", "네트워크 연결상태를 확인하세요.", "Ok");
            }
            //응답이 다 넘어온 경우 비활성화 시킴
            activityIndicator.IsVisible = false;
        }
        //선택한 사원을 다음 화면에 출력
        private async void listView_ItemSelected(object sender,
       SelectedItemChangedEventArgs e)
        {
            /* 응답 JSON 형식
            {"empno":1001,"ename":"TopCredu","sal":6000,"job":"CLERK"}
            */
            activityIndicator.IsVisible = true;
            var Emp = e.SelectedItem as Model.Emp;
            var nextPage = new View.EmpViewPage();

            //웹서비스 호출 URL 생성
            string url = "http://192.168.0.214:8080/emp/" + Emp.Empno;
            // 네트워크 연결 상태 확인
            if (CrossConnectivity.Current.IsConnected)
            {
                var client = new HttpClient();
                var res = await client.GetAsync(url);
                string ResponseStr = await
               res.Content.ReadAsStringAsync();
                if (ResponseStr != "")
                {

                    // 웹서비스에서 리턴하는 JSON 형식을 EmpList 형식으로 변환
                nextPage.BindingContext = JsonConvert.DeserializeObject<Model.Emp>(ResponseStr);
                }
            }
            else
            {
                await DisplayAlert("에러!", "네트워크 연결상태를 확인하세요.", "Ok");
            }
            //응답이 다 넘어온 경우 비활성화 시킴
            activityIndicator.IsVisible = false;
            await Navigation.PushAsync(nextPage);
        }
    }
}