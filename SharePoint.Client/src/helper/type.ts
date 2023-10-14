export interface typeStyleVideo {
  color: string;
  width: string;
  height: string;
}
export interface typeDataAnnouncement {
  id: number;
  img: string;
  title: string;
  subTitle: string;
  date: string;
  titleBtn: string;
}

export interface typeDataNews {
  id: number;
  img: string;
  title: string;
  subTitle: string;
  date: string;
}

export interface typeDataImg {
  id: number;
  img: string;
  title: string;
}

export interface typeDataVideo {
  id: number;
  img: string;
  title: string;
}

export interface typeDataQuick {
  id: number;
  title: string;
  img: string;
  titleImg: string;
  width: string;
  height: string;
}

export interface typeDataHow {
  id?: number;
  title?: string;
  content?: string;
}

export interface typeDataEvents {
  id: number;
  day: string;
  month: string;
  title: string;
  time: string;
}

export interface typeDataDocument {
  id: number;
  title: string;
  titleChildren?: string;
  children?: {
    id: number;
    img: any;
    titleImg: string;
    subTitle: string;
  }[];
  data: {
    id: number;
    img: any;
    titleImg: string;
    subTitle: string;
  }[];
}
