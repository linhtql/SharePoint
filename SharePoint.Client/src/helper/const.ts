import Image from "../../src/Base/Image";
import {
  typeStyleVideo,
  typeDataAnnouncement,
  typeDataNews,
  typeDataVideo,
  typeDataImg,
  typeDataQuick,
  typeDataHow,
  typeDataEvents,
  typeDataDocument,
} from "./type";

export const styleVideo: typeStyleVideo = {
  color: "#FFFFFF",
  width: "48px",
  height: "48px",
};

export const styleMenu: typeStyleVideo = {
  color: "#333333",
  width: "40px",
  height: "40px",
};

export const styleIcon: typeStyleVideo = {
  color: "#333333",
  width: "25px",
  height: "30px",
};

export const dataAnnouncement: typeDataAnnouncement[] = [
  {
    id: 1,
    img: Image.image_gallery,
    title: "New Learning System Is Live",
    subTitle:
      "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
    date: "05/Jan/2021",
    titleBtn: "Human Resource",
  },
  {
    id: 2,
    img: Image.image_gallery_1,
    title: "IT Maintenance",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
    titleBtn: "Human Resource",
  },
  {
    id: 3,
    img: Image.image_gallery_2,
    title: "IT Maintenance",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
    titleBtn: "Human Resource",
  },
  {
    id: 4,
    img: Image.image_gallery_3,
    title: "IT Maintenance",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
    titleBtn: "Human Resource",
  },
];

export const dataNews: typeDataNews[] = [
  {
    id: 1,
    img: Image.image_gallery,
    title: "Tomorrow Healthy Check",
    subTitle:
      "New Wellness Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo d ea rebum. gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet... consetetur sadip m ipsum dolor sit amet, consetetur sadim ipsum dolorsadi...",
    date: "05/Jan/2021",
  },
  {
    id: 2,
    img: Image.image_gallery_1,
    title: "Air-conditioning is broken",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
  },
  {
    id: 3,
    img: Image.image_gallery_2,
    title: "IT Maintenance",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
  },
  {
    id: 4,
    img: Image.image_gallery_3,
    title: "IT Maintenance",
    subTitle:
      "Lorem ipsum dolor sit amet, consetetur sadipscing elitrinvidunt ut labore et dolore aaliquya erat, sed diam voluptuaaa vero eos et accusam et justo duo",
    date: "02/Jan/2021",
  },
];

export const dataImg: typeDataImg[] = [
  {
    id: 1,
    img: Image.image_gallery,
    title: "img1",
  },
  {
    id: 2,
    img: Image.image_gallery_1,
    title: "img2",
  },
  {
    id: 3,
    img: Image.image_gallery_2,
    title: "img3",
  },
  {
    id: 4,
    img: Image.image_gallery_3,
    title: "img4",
  },
];

export const dataVideo: typeDataVideo[] = [
  {
    id: 1,
    img: Image.video,
    title: "video1",
  },
  {
    id: 2,
    img: Image.video_1,
    title: "video2",
  },
  {
    id: 3,
    img: Image.video_2,
    title: "video3",
  },
  {
    id: 4,
    img: Image.video_3,
    title: "video4",
  },
];

export const dataDocument: typeDataDocument[] = [
  {
    id: 1,
    title: "Policy",
    data: [
      {
        id: 1,
        img: Image.word,
        titleImg: "word",
        subTitle: "Policy 1",
      },
      {
        id: 2,
        img: Image.word,
        titleImg: "word",
        subTitle: "Policy 2",
      },
      {
        id: 3,
        img: Image.word,
        titleImg: "word",
        subTitle: "Policy 4",
      },
      {
        id: 4,
        img: Image.word,
        titleImg: "word",
        subTitle: "Policy 6",
      },
    ],
  },
  {
    id: 2,
    title: "SOP",
    data: [
      {
        id: 1,
        img: Image.word,
        titleImg: "word",
        subTitle: "Demo Script",
      },
      {
        id: 2,
        img: Image.word,
        titleImg: "word",
        subTitle: "App Introduction",
      },
      {
        id: 3,
        img: Image.word,
        titleImg: "word",
        subTitle: "Index",
      },
      {
        id: 4,
        img: Image.word,
        titleImg: "word",
        subTitle: "Training",
      },
    ],
  },
  {
    id: 3,
    title: "Corporate Template",
    titleChildren: "Slider",
    children: [
      {
        id: 1,
        img: Image.powerpoint,
        titleImg: "template",
        subTitle: "Template 1",
      },
      {
        id: 2,
        img: Image.powerpoint,
        titleImg: "template",
        subTitle: "Template 2",
      },
      {
        id: 3,
        img: Image.powerpoint,
        titleImg: "template",
        subTitle: "Template 3",
      },
    ],
    data: [
      {
        id: 1,
        img: Image.word,
        titleImg: "word",
        subTitle: "Template 1",
      },
      {
        id: 2,
        img: Image.word,
        titleImg: "word",
        subTitle: "Template 2",
      },
      {
        id: 3,
        img: Image.word,
        titleImg: "word",
        subTitle: "Template 3",
      },
    ],
  },
  {
    id: 4,
    title: "Report",
    data: [
      {
        id: 1,
        img: Image.vsdx,
        titleImg: "report",
        subTitle: "Report 1",
      },
      {
        id: 2,
        img: Image.vsdx,
        titleImg: "report",
        subTitle: "Report 2",
      },
      {
        id: 3,
        img: Image.vsdx,
        titleImg: "report",
        subTitle: "Report 3",
      },
      {
        id: 4,
        img: Image.vsdx,
        titleImg: "report",
        subTitle: "Report 1",
      },
    ],
  },
];

export const dataQuick: typeDataQuick[] = [
  {
    id: 1,
    title: "Training",
    img: Image.icon,
    titleImg: "training",
    width: "24px",
    height: "37px",
  },
  {
    id: 2,
    title: "Organization",
    img: Image.icon_1,
    titleImg: "organization",
    width: "45px",
    height: "37px",
  },
  {
    id: 3,
    title: "Task",
    img: Image.icon_2,
    titleImg: "task",
    width: "36px",
    height: "37px",
  },
  {
    id: 4,
    title: "Global Sales",
    img: Image.icon_3,
    titleImg: "globalSales",
    width: "34px",
    height: "37px",
  },
  {
    id: 5,
    title: "Birthday",
    img: Image.icon_4,
    titleImg: "birthday",
    width: "32px",
    height: "37px",
  },
  {
    id: 6,
    title: "Health",
    img: Image.icon_5,
    titleImg: "health",
    width: "36px",
    height: "37px",
  },
  {
    id: 7,
    title: "Service Desk",
    img: Image.icon_6,
    titleImg: "serviceDesk",
    width: "40px",
    height: "37px",
  },
  {
    id: 8,
    title: "Truck",
    img: Image.icon_7,
    titleImg: "truck",
    width: "45px",
    height: "37px",
  },
  {
    id: 9,
    title: "Idea",
    img: Image.icon_8,
    titleImg: "idea",
    width: "27px",
    height: "37px",
  },
];

export const dataEvents: typeDataEvents[] = [
  {
    id: 1,
    day: "01",
    month: "Jan",
    title: "Register Portal",
    time: "09:00 AM - 09:30 AM",
  },
  {
    id: 2,
    day: "02",
    month: "Jan",
    title: "IT Maintenance",
    time: "09:00 AM - 09:30 AM",
  },
  {
    id: 3,
    day: "03",
    month: "Jan",
    title: "IT Maintenance",
    time: "09:00 AM - 09:30 AM",
  },
  {
    id: 4,
    day: "04",
    month: "Jan",
    title: "IT Maintenance",
    time: "09:00 AM - 09:30 AM",
  },
];

export const dataHow: typeDataHow[] = [
  {
    id: 1,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 2,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 3,
    title: "Commodo consequat. Duis auteequat.",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 4,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 5,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 6,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 7,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 8,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 9,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
  {
    id: 10,
    title: "Lorem ipsum dolor sit amet",
    content:
      "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut aliqubore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisiut aliquip ex ea commodo consequat. Duis uis nostrud exercitation ullamco laboris nisiut aliquip ex uis nostrud exercitation ullamco laboris nisiut ip ex.",
  },
];
