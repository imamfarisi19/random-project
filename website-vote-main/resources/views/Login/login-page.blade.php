<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <link rel="kpu-panwaslu-umbjm" sizes="76x76" href="../assets/img/logo/kpu-univ.png">
    <link rel="icon" type="image/png" href="../assets/img/logo/kpu-univ.png">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta name="author" content="Imam Farisi">
    <meta name="description" content="Komisi Peimilihan Umum Universitas Muhammadiyah Banjarmasin">
    <meta http-equiv="refresh" content="30">
    <title>Login | KPU UM Banjarmasin</title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0, shrink-to-fit=no' name='viewport' />

    <!--     Fonts and icons     -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.1/css/all.css" integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">

    <!-- CSS Files -->
    <link href="{{ asset('../assets/css/bootstrap.min.css') }}" rel="stylesheet" />
    <link href="{{ asset('../assets/css/now-ui-kit.css?v=1.3.0') }}" rel="stylesheet" />

    <!-- CSS Just for demo purpose, don't include it in your project -->
    <link href="{{ asset('../assets/demo/demo.css') }}" rel="stylesheet" />
</head>

<body class="login-page sidebar-collapse">

    <!-- Navbar -->
    <nav class="navbar navbar-expand-lg bg-info fixed-top navbar-transparent " color-on-scroll="400">
        <div class="container">
            <div class="dropdown button-dropdown">
                <a href="#pablo" class="dropdown-toggle" id="navbarDropdown" data-toggle="dropdown">
                    <span class="button-bar"></span>
                    <span class="button-bar"></span>
                    <span class="button-bar"></span>
                </a>
                <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                    <a class="dropdown-header">Dropdown header</a> 
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="/">Home</a>
                    <div class="dropdown-divider"></div>
                    <a class="dropdown-item" href="/profile">Profile</a>
                </div>
            </div>
            <div class="navbar-translate">
                <button class="navbar-toggler navbar-toggler" type="button" data-toggle="collapse" data-target="#navigation" aria-controls="navigation-index" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-bar top-bar"></span>
                    <span class="navbar-toggler-bar middle-bar"></span>
                    <span class="navbar-toggler-bar bottom-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse justify-content-end" id="navigation" data-nav-image="../assets/img/blurred-image-1.jpg">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="/">Kembali</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" rel="tooltip" title="Follow us on Instagram" data-placement="bottom" href="https://www.instagram.com/kpupanwaslu_umbjm/" target="_blank">
                            <i class="fab fa-instagram"></i>
                            <p class="d-lg-none d-xl-none">Instagram</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- End Navbar -->
    <div class="page-header clear-filter" filter-color="orange">
        <div class="page-header-image" style="background-image:url(../assets/img/logo/cat-eye.jpg)"></div>
        <div class="content">
            <div class="container">
                <div class="col-md-4 ml-auto mr-auto">
                    <div class="card card-login card-plain">
                        <form class="form" method="post" action="{{ route('postlogin') }}">
                            {{ csrf_field() }}
                            <div class="card-header text-center">
                                <div class="logo-container">
                                    <img src="../assets/img/logo/kpu-univ.png" alt="">
                                </div>
                            </div>
                            <div class="card-body">
                                <div class="input-group no-border input-lg">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                          <i class="now-ui-icons users_single-02"></i>
                                        </span>
                                    </div>
                                    <input type="text" class="form-control" name="email" placeholder="username">
                                </div>
                                <div class="input-group no-border input-lg">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text">
                                          <i class="now-ui-icons objects_key-25"></i>
                                        </span>
                                    </div>
                                    <input type="text" class="form-control" name="password" placeholder="password"/>
                                </div>
                            </div>
                            <div class="card-footer text-center">
                                <button class="btn btn-primary btn-round btn-lg btn-block">Login</button>
                                <div class="pull-left">
                                    <h6>
                                        <a href="#pablo" class="link">Create Account</a>
                                    </h6>
                                </div>
                                <div class="pull-right">
                                    <h6>
                                        <a href="#pablo" class="link">Need Help?</a>
                                    </h6>
                                </div>
                        </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer class="footer">
            <div class=" container ">
                <nav>
                    <ul>
                        <li>
                            <a href="https://www.instagram.com/kpupanwaslu_umbjm/">
                              Instagram
                            </a>
                        </li>
                    </ul>
                </nav>
                <div class="copyright" id="copyright">
                    &copy;
                    <script>
                        document.getElementById('copyright').appendChild(document.createTextNode(new Date().getFullYear()))
                    </script>, Designed by
                    <a href="https://www.invisionapp.com" target="_blank">Invision</a>. Coded by
					<a href="#" target="_blank">Imam Farisi</a>.
                </div>
            </div>
        </footer>
    </div>
    <!--   Core JS Files   -->
    <script src="{{ asset('../assets/js/core/jquery.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('../assets/js/core/popper.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('../assets/js/core/bootstrap.min.js') }}" type="text/javascript"></script>
    <!--  Plugin for Switches, full documentation here: http://www.jque.re/plugins/version3/bootstrap.switch/ -->
    <script src="{{ asset('../assets/js/plugins/bootstrap-switch.js') }}"></script>
    <!--  Plugin for the Sliders, full documentation here: http://refreshless.com/nouislider/ -->
    <script src="{{ asset('../assets/js/plugins/nouislider.min.js') }}" type="text/javascript"></script>
    <!--  Plugin for the DatePicker, full documentation here: https://github.com/uxsolutions/bootstrap-datepicker -->
    <script src="{{ asset('../assets/js/plugins/bootstrap-datepicker.js') }}" type="text/javascript"></script>
    <!--  Google Maps Plugin    -->
    <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE"></script>
    <!-- Control Center for Now Ui Kit: parallax effects, scripts for the example pages etc -->
    <script src="{{ asset('../assets/js/now-ui-kit.js?v=1.3.0') }}" type="text/javascript"></script>
</body>

</html>

