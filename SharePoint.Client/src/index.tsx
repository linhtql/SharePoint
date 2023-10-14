import React from "react";
import ReactDOM from "react-dom";
import "./index.scss";
import Layout from "./Base/Layout";
import { IconContext } from "react-icons";

ReactDOM.render(
  <IconContext.Provider value={{ className: "react-icons" }}>
    <Layout />
  </IconContext.Provider>,
  document.getElementById("root")
);
