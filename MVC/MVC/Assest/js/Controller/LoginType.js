var UserType = [];
var a = new Vue({
    el: '#UserType',
    methods: {
        LoginTypeMethod: function () {
            if (localStorage.setItem("UserType") != null) {
                window.location.href = '/User/UserPage';
            }
            else {
                $("#LoginModal").modal('show');
            }
        }

    },
})


