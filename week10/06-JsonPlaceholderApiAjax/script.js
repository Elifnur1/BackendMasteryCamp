$(document).ready(function () {
    function loadPosts() {
        $.ajax({
            url: 'https://jsonplaceholder.typicode.com/posts',
            method: 'GET',
            success: function (posts) {
                let postsHtml = '';
                posts.forEach(posts => {
                    postsHtml += `
            <div class="col-3">

            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">${posts.id} </h5>
                    <p class="card-text">${posts.title} .</p>
                    <a href="#" class="btn btn-primary">Oku</a>
                </div>
            </div>
            </div>
                 `
                });
                $('#posts').html(postsHtml)
            },
            error: function (err) {
                console.log(err);
            }
        });
    };
    loadPosts();
})