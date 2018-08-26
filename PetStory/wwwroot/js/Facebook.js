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

				if (window.location.pathname !== '/Home' && window.location.pathname !== '/')
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