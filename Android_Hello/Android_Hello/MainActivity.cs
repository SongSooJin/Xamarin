using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Text;
using Android.Widget;
using System;
using Android.Content;
using System.Collections.Generic;

// Muliti Screen Example

namespace Android_Hello
{
    // Label : 타이틀 MainLauncher : 최초에 실행되는화면
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        // CallHistoryButton의 이벤트 핸들러 등록 
        static readonly List<string> phoneNumbers = new List<string>();

        // 필수 무조건 정의 해야됨(콜백 메소드)
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // CallHistoryButton의 이벤트 핸들러 등록 
            Button callHistoryButton = FindViewById<Button>(Resource.Id.CallHistoryButton);
            callHistoryButton.Click += (sender, e) =>
            {
                // 인텐트는 액티비티의 전환이 일어날 때 호출하거나 메시지를 전달하는 매개체
                // 암시적 인텐트 : 전환될 곳을 직접 지정하지 않고 액션을 적어서 사용한다.
                // 명시적 인텐트 : 전환될 액티비티를 직접 적어서 표현하는 방법을 사용한다.
                var intent = new Intent(this, typeof(CallHistoryActivity));

                // PutStringArrayExtra는 Intent에 전화번호 목록을 첨부한다.
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };

            // Resource.Id
            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);

            // 전화걸기 버튼
            Button callButton = FindViewById<Button>(Resource.Id.CallButton);

            // 버튼 비활성화
            callButton.Enabled = false;

            phoneNumberText.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                if (!string.IsNullOrWhiteSpace(phoneNumberText.Text))
                {
                    callButton.Enabled = true;
                }
                else
                {
                    callButton.Enabled = false;
                }
            };

            callButton.Click += (object sender, EventArgs e) =>
            {
                //Make a Call 버튼 클릭시 전화를 건다
                var callDialog = new Android.App.AlertDialog.Builder(this);
                callDialog.SetMessage("Call" + phoneNumberText.Text + "?");

                // Call을 클릭하는 경우
                // 전화를 걸기 위한 인텐트 생성
                callDialog.SetNeutralButton("Call", delegate
                {

                    phoneNumbers.Add(phoneNumberText.Text);
                    callHistoryButton.Enabled = true;
                    //인텐트는 액티비티의 전환이 일어날 때 호출하거나 메시지를 전달하는 매개체
                    // 암시적 인텐트 : 전환될 곳을 직접 지정하지 않고 액션을 적어서 사용한다.
                    // 명시적 인텐트 : 전환될 액티비티를 직접 적어서 표현하는 방법을 사용한다.

                    // 안드로이드 시스템 앱을 부를때 Intent를 쓴다
                    // () 안은 액티비티를 넣을때는 명시적 인텐트
                    // 액션을 넣어 안드로이드 시스템앱을 부른다 암시적 인텐트
                    var callIntent = new Intent(Intent.ActionCall);
                    callIntent.SetData(Android.Net.Uri.Parse("tel: " + phoneNumberText.Text));

                    StartActivity(callIntent);
                });

                //Cancel을 클릭하는 경우
                callDialog.SetNegativeButton("Cancel", delegate { });
                callDialog.Show();
            };
        }
    }
}



