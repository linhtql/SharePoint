import React from "react";
import "./index.scss";
import { CgMenuGridR } from "react-icons/cg";
import { AiOutlineBell } from "react-icons/ai";
import { FiSettings } from "react-icons/fi";
import { BsQuestionLg } from "react-icons/bs";
import { BiDotsHorizontalRounded } from "react-icons/bi";
import Image from "../../Base/Image";
import { VscSearch } from "react-icons/vsc";
class Menu extends React.Component {
  render() {
    return (
      <div className="wrapper__menu">
        <div className="menu__left">
          <div className="menu__left--icon">
            <CgMenuGridR />
          </div>

          <h3 className="menu__left--text">SharePoint</h3>
        </div>
        <div className="menu__search">
          <div className="menu__search--icon">
            <img
              src={Image.search}
              alt="Avatar"
              className="menu__search--icon--img"
            />
          </div>
          <div className="menu__search--text">
            <p>Search in SharePoint</p>
          </div>
        </div>
        <div className="menu__right">
          <div className="menu__right--tablet">
            <VscSearch />
            <BiDotsHorizontalRounded />
          </div>
          <div className="menu__right--desktops">
            <AiOutlineBell />
            <FiSettings />
            <BsQuestionLg />
          </div>

          <div className="menu__right--img">
            <img src={Image.avatar} alt="Avatar" />
          </div>
        </div>
      </div>
    );
  }
}

export default Menu;
