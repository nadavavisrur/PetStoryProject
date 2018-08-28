function InitialFacebook(appId) {
	window.fbAsyncInit = function () {
		FB.init({
			appId: appId,
			cookie: true,
			xfbml: true,
			version: 'v3.1'
		});

		FB.AppEvents.logPageView();

		//FB.Event.subscribe('auth.login', function (response) {
		//	var credentials = { uid: response.authResponse.userID, accessToken: response.authResponse.accessToken };
		//	SubmitLogin(credentials);
		//});

		FB.getLoginStatus(function (response) {
            if (response.status === 'connected') {
				console.log("user is logged into fb");

                checkIfExist(response.authResponse);
				if (window.location.pathname === '/Home/Login')
					window.location.href = '/Home';
			}
			else if (response.status === 'not_authorized') {
				if (window.location.pathname !== '/Home/Login')
					window.location.href = '/Home/Login';
			}
			else {
				if (window.location.pathname !== '/Home/Login')
					window.location.href = '/Home/Login';
			}

        });

        function checkIfExist(userDetails) {
            $.ajax({
                type: 'GET',
                url: '/Owners/Facebook/' + userDetails.userID,
                success: function (result) {
                    if (!result) {
                        addNewUser({ ID: userDetails.userID, token: userDetails.accessToken });
                    }
                },
                error: function (err) {
                    console.log("Something went wrong: ");
                    console.log(err);
                }
            });
        }

        function addNewUser(details) {
            FB.api('/me', { fields: 'name,picture' }, function (response) {
                var __AjaxAntiForgeryForm = $("#__AjaxAntiForgeryForm input");
                var data = "name=" + response.name
                    + "&image=" + response.picture.data.url
                    + "&facebookID=" + details.ID
                    + "&birthday=" + (new Date()).toISOString()
                    + "&city=default"
                    + "&__RequestVerificationToken=" + __AjaxAntiForgeryForm.attr("value");

                $.ajax({
                    type: 'POST',
                    url: '/Owners/Create',
                    data: encodeURI(data),
                    success: function (result) {
                        // Nothing to do - user has beem added
                    },
                    error: function (err) {
                        console.log("Something went wrong: ");
                        console.log(err);
                    }
                });
                console.log(response);
            })
        }
		function SubmitLogin(credentials) {
			$.ajax({
				url: "/account/facebooklogin",
				type: "POST",
				data: credentials,
				error: function () {
					alert("error logging in to your facebook account.");
				},
				success: function () {
					window.location.reload();
				}
			});
		}

	};

	(function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0];
		if (d.getElementById(id)) { return; }
		js = d.createElement(s); js.id = id;
		js.src = "https://connect.facebook.net/en_US/sdk.js";
		fjs.parentNode.insertBefore(js, fjs);
	}(document, 'script', 'facebook-jssdk'));
}