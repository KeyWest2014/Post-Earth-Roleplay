resource_manifest_version "44febabe-d386-4d18-afbe-5e627f4af937"
fx_version "adamant"
games {
	"gta5"
}

loadscreen "www/loadingscreen.html"
ui_page "www/loginportal.html"

files {
	"www/loadingscreen.html",
	"www/loginportal.html",

	"assets/img/background.png",

	"assets/js/bootstrap.min.js.js",
	"assets/js/jquery-3.4.1.min.js",
	"assets/js/popper.min.js",
	"assets/js/loadingscreen.js",

	"assets/css/bootstrap.min.css",
	"assets/css/loadingscreen.css",

	"assets/fonts/gravity.woff2"
}

client_script {
	"PostEarthClient.net.dll"
}

server_script {
	"PostEarthServer.net.dll"
}

