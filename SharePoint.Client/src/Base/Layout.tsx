import React from "react";
import "./layout.scss";
import Navigation from "../Components/Navigation/Navigation";
import Menu from "../Components/Menu/Menu";
import Announcement from "../Components/Announcement/Announcement";
import News from "../Components/News/New";
import Images from "../Components/Images/Images";
import Video from "../Components/Video/Video";
import Document from "../Components/Document/Document";
import Quick from "../Components/Quick/Quick";
import Events from "../Components/Events/Events";
import How from "../Components/How/How";
export default class Layout extends React.Component {
  render() {
    return (
      <>
        <Menu />
        <div className="portal__homepage">
          <div className="wrap">
            <div className="header">
              <Navigation />
            </div>
            <div className="content">
              <div className="content__left">
                <div id="announcement">
                  <Announcement />
                </div>
                <div id="news">
                  <News />
                </div>
                <div id="image-gallery">
                  <Images />
                </div>
                <div id="video-gallery">
                  <Video />
                </div>
                <div id="document-gallery">
                  <Document />
                </div>
              </div>
              <div className="content__right">
                <div id="quick-links">
                  <Quick />
                </div>
                <div id="events">
                  <Events />
                </div>
                <div id="how-do-i">
                  <How />
                </div>
              </div>
            </div>
          </div>
        </div>
      </>
    );
  }
}
