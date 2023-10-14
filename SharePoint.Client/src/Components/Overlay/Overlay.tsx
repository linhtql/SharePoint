import React, { Component } from "react";
import ReactDOM from "react-dom";
import "./index.scss";

export default class Overlay extends Component {
  render() {
    return ReactDOM.createPortal(
      <div className="overlay">{this.props.children}</div>,
      document.getElementById("overlay")!
    );
  }
}
