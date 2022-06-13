$.ajax({
    type: 'GET',
    url: 'https://github.com/benoitvallon/100-best-books/blob/master/books.json',
    dataType: 'json',
    success: function(data) {
        var books = data.books;
        var book = books[Math.floor(Math.random() * books.length)];
        $('#book-title').text(book.title);
        $('#book-author').text(book.author);
        $('#book-description').text(book.description);
        $('#book-cover').attr('src', book.cover);
    }
});
  