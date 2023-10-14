
using Newtonsoft.Json;
using Sharepoint.Data.Model;

var information = PrepairInformation();
var qa = PrepairQa();
var eventt = PrepairEvent();
var gallery = PrepairGallery();
var jsonSetting = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

var informationJson = JsonConvert.SerializeObject(information, jsonSetting);
var qaJson = JsonConvert.SerializeObject(qa, jsonSetting);
var eventJson = JsonConvert.SerializeObject(eventt, jsonSetting);
var galleryJson = JsonConvert.SerializeObject(gallery, jsonSetting);



await File.WriteAllTextAsync("information.json", informationJson);
await File.WriteAllTextAsync("qa.json", qaJson);
await File.WriteAllTextAsync("event.json", eventJson);
await File.WriteAllTextAsync("gallery.json", galleryJson);


static List<Information> PrepairInformation()
{
    var result = new List<Information>();
    #region News
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.News,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
        "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "Air-conditioning is broken",
        Description = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt" +
        " ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d" +
        " ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum" +
        " dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new NewsExtension
        {

        }

    });

    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.News,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
        "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "Tomorrow Healthy Check",
        Description = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt" +
        " ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea " +
        "rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... " +
        "consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new NewsExtension
        {

        }

    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.News,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
        "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
        " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new NewsExtension
        {

        }
    });

    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.News,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
    "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
    " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new NewsExtension
        {

        }
    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.News,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
"wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
" labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new NewsExtension
        {

        }
    });



    #endregion
    #region Announcement
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.Announcement,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
        "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "New Learning System Is Live",
        Description = "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt" +
        " ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d " +
        "ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor " +
        "sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new AnnouncementExtension
        {
            Button = "Human Resource"
        }

    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.Announcement,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
    "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
        " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new AnnouncementExtension
        {
            Button = "Human Resource"
        }

    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.Announcement,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
    "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
        " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new AnnouncementExtension
        {
            Button = "Human Resource"
        }

    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.Announcement,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
    "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
        " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new AnnouncementExtension
        {
            Button = "Human Resource"
        }

    });
    result.Add(new Information
    {
        Id = Guid.NewGuid().ToString(),
        Type = InformationType.Announcement,
        ImageUrl = "https://thumbs.dreamstime.com/b/news-newspapers-folded-stacked-word-" +
    "wooden-block-puzzle-dice-concept-newspaper-media-press-release-42301371.jpg",
        Title = "IT Maintenance",
        Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut" +
        " labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
        CreatedDate = new DateOnly(2023, 09, 08),
        Extension = new AnnouncementExtension
        {
            Button = "Human Resource"
        }

    });
    #endregion

    return result;
}
static List<QA> PrepairQa()
{
    var result = new List<QA>();
    result.Add(new QA
    {
        Id = Guid.NewGuid().ToString(),
        Question = "Lorem ipsum dolor sit amet",
        Answer = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
        "quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. " +
        "Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation" +
        " ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis" +
        " nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis " +
        "nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco " +
        "laboris nisiut ip ex."
    });
    result.Add(new QA
    {
        Id = Guid.NewGuid().ToString(),
        Question = "Lorem ipsum dolor sit amet",
        Answer = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
        "quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. " +
        "Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation" +
        " ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis" +
        " nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis " +
        "nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco " +
        "laboris nisiut ip ex."
    });
    result.Add(new QA
    {
        Id = Guid.NewGuid().ToString(),
        Question = "Lorem ipsum dolor sit amet",
        Answer = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, " +
        "quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. " +
        "Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation" +
        " ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis" +
        " nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis " +
        "nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco " +
        "laboris nisiut ip ex."
    });
    return result;
}

static List<Event> PrepairEvent()
{
    var result = new List<Event>();
    result.Add(new Event
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Register Portal",
        CreateDate = new DateOnly(2023, 09, 11),
        StartTime = TimeOnly.FromDateTime(DateTime.Now),
        EndTime = (TimeOnly.FromDateTime(DateTime.Now)).AddHours(5)

    });

    result.Add(new Event
    {
        Id = Guid.NewGuid().ToString(),
        Name = "IT Maintenance",
        CreateDate = new DateOnly(2023, 09, 11),
        StartTime = TimeOnly.FromDateTime(DateTime.Now),
        EndTime = (TimeOnly.FromDateTime(DateTime.Now)).AddHours(5)

    });

    result.Add(new Event
    {
        Id = Guid.NewGuid().ToString(),
        Name = "IT Maintenance",
        CreateDate = new DateOnly(2023, 09, 11),
        StartTime = TimeOnly.FromDateTime(DateTime.Now),
        EndTime = (TimeOnly.FromDateTime(DateTime.Now)).AddHours(5)

    });
    result.Add(new Event
    {
        Id = Guid.NewGuid().ToString(),
        Name = "IT Maintenance",
        CreateDate = new DateOnly(2023, 09, 11),
        StartTime = TimeOnly.FromDateTime(DateTime.Now),
        EndTime = (TimeOnly.FromDateTime(DateTime.Now)).AddHours(5)

    });


    return result;
}
static List<Gallery> PrepairGallery()
{
    var result = new List<Gallery>();

    #region Image
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Image,
        Extension = new ImageGalleryExtension
        {
            ImageUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }
    });

    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Image,
        Extension = new ImageGalleryExtension
        {
            ImageUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }
    });

    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Image,
        Extension = new ImageGalleryExtension
        {
            ImageUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }
    });

    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Image,
        Extension = new ImageGalleryExtension
        {
            ImageUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }
    });

    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Image,
        Extension = new ImageGalleryExtension
        {
            ImageUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }
    });
    #endregion
    #region Video
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Video,
        Extension = new VideoGalleryExtension
        {
            VideoUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }

    });
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Video,
        Extension = new VideoGalleryExtension
        {
            VideoUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }

    });
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Video,
        Extension = new VideoGalleryExtension
        {
            VideoUrl = "https://media.istockphoto.com/id/1369150014/vector/breaking-news-with-world-map-background-vector.jpg?s=612x612&w=0&k=20&c=9pR2-nDBhb7cOvvZU_VdgkMmPJXrBQ4rB1AkTXxRIKM="
        }

    });
    #endregion
    #region Document
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Document,
        Extension = new DocumentGalleryExtension
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Policy",
            Type = DocumentType.Policy,
            Extension = new DocType
            {
                Id = Guid.NewGuid().ToString(),
                ImageUrl = "test",
                Title = "test",
            }
        }
    });
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Document,
        Extension = new DocumentGalleryExtension
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Policy",
            Type = DocumentType.Policy,
            Extension = new DocType
            {
                Id = Guid.NewGuid().ToString(),
                ImageUrl = "test",
                Title = "test",
            }
        }
    });
    result.Add(new Gallery
    {
        Id = Guid.NewGuid().ToString(),
        Name = "Image",
        Type = GalleryType.Document,
        Extension = new DocumentGalleryExtension
        {
            Id = Guid.NewGuid().ToString(),
            Name = "Policy",
            Type = DocumentType.Policy,
            Extension = new DocType
            {
                Id = Guid.NewGuid().ToString(),
                ImageUrl = "test",
                Title = "test",
            }
        }
    });
    return result;
    #endregion
}