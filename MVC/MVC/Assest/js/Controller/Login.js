var a = new Vue({
    el: '#LoginModal',
    data: {
        LoginEmail: '',
        LoginPassword: '',
        LoginerrorMsg: '',
        LoginPassworderrorMsg: ''
    },
    methods: {
        LoginMethod: function () {
            console.log('login');
            let data = {
                LoginEmail: this.LoginEmail,
                LoginPassword: this.LoginPassword
            }
            $.ajax({
                url: '/api/CustomerManager/Login',
                type: 'POST',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                async: true,
                success: function (response) {
                    console.log(response);
                    if (response.StatusCode == '1') {
                        window.location.href = '/Home/Index';
                    }
                    else if (response.StatusCode == '2') {
                        alert("此帳戶不存在");
                    } else {
                        alert("密碼錯誤");
                    }
                }
            });


        }

    },
    watch: {
        check: function () {
            if (this.account.length < 5 || this.account.length > 10) {
                return errorMsg = `請輸入5~10碼`
            }
        },
        checkPassword: function () {
            if (this.password.length < 5 || this.password.length > 10) {
                return PassworderrorMsg = `請輸入5~10碼`
            }
        }

    }
})


