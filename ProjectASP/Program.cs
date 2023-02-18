// ReSharper disable CommentTypo
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    // если обращение идет по адресу "/postuser", получаем данные формы
    // ReSharper disable once StringLiteralTypo
    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        string[] languages = form["languages"];
        // создаем из массива languages одну строку
        string langList = "";
        foreach (var lang in languages)
        {
            langList += $" {lang}";
        }
        await context.Response.WriteAsync($"<div><p>Name: {name}</p>" +
                                          $"<p>Age: {age}</p>" +
                                          $"<ul>Languages:{langList}</ul></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});

app.Run();
