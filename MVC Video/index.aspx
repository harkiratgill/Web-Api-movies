
<!DOCTYPE html>
<html lang="en">


<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Movie Info</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">/ <!--these are the external css-->
    <link href="css/style.css" rel="stylesheet">
</head>
<body>
        <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse"> <!--this is the nav bar-->
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span> 
                    <span class="icon-bar"></span>
                    <a href="Video/Index">Back Home</a>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    
                     <a href="Video/Index">Back Home</a> <!--this takes you back home-->
                   

                </ul>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="jumbotron">
            <h3 class="text-center">Search For Any Movie</h3><!--this is the heading-->
            <form id="searchForm">
                <input type="text" class="form-control" id="searchText" placeholder="Search Movie...."> <!--this is the serch bar-->
            </form>
        </div>
    </div>
    <div class="container">
        <div id="movies" class="row"></div>
    </div>

    
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script> <!--these are the scripts-->
    <script src="js/axios.min.js"></script>
    <script type="text/javascript" src="js/main.js"></script>
</body>

</html>
