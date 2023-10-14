import React, { JSX } from "react";
import "./index.scss";
import Image from "../../Base/Image";
import { AiOutlineMenuUnfold } from "react-icons/ai";
import { GiCancel } from "react-icons/gi";
import { styleMenu, styleIcon } from "../../helper/const";
import Overlay from "../Overlay/Overlay";
import { GrCircleInformation } from "react-icons/gr";
import {
  MdOutlineMiscellaneousServices,
  MdOutlineProductionQuantityLimits,
  MdContactSupport,
} from "react-icons/md";
import { BsListOl } from "react-icons/bs";

type State = {
  nav: { name: string; icon: JSX.Element }[];
  isShow: boolean;
};

export default class Navigation extends React.Component<{}, State> {
  state: State = {
    nav: [
      { name: "About", icon: <GrCircleInformation style={styleIcon} /> },
      {
        name: "Services",
        icon: <MdOutlineMiscellaneousServices style={styleIcon} />,
      },
      {
        name: "Products",
        icon: <MdOutlineProductionQuantityLimits style={styleIcon} />,
      },
      {
        name: "List",
        icon: <BsListOl style={styleIcon} />,
      },
      {
        name: "Support",
        icon: <MdContactSupport style={styleIcon} />,
      },
    ],
    isShow: false,
  };

  hideOverlay = () => {
    this.setState((prevState) => ({ isShow: !prevState.isShow }));
  };

  render() {
    return (
      <>
        <div className="nav">
          <div className="nav__logo">
            <img src={Image.logo} alt="logo" />
          </div>
          <div className="nav__items">
            {this.state.nav.map((item, index) => {
              return (
                <div key={index} className="nav__item">
                  {item.name}
                </div>
              );
            })}
          </div>
          <div className="nav__menu" onClick={this.hideOverlay}>
            <AiOutlineMenuUnfold style={styleMenu} />
          </div>
        </div>
        {this.state.isShow && (
          <Overlay>
            <div className={`nav__overlay`}>
              <div className="nav__overlay--cancel" onClick={this.hideOverlay}>
                <GiCancel style={styleMenu} />
              </div>
              <div className="nav__overlay--items">
                {this.state.nav.map((item, index) => {
                  return (
                    <div className="nav__overlay--flex">
                      <div className="nav__overlay--icon">{item.icon}</div>
                      <div key={index} className="nav__overlay--item">
                        {item.name}
                      </div>
                    </div>
                  );
                })}
              </div>
            </div>
          </Overlay>
        )}
      </>
    );
  }
}
