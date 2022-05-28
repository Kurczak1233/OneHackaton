import MainPageHeading from "../../components/MainPageHeading/MainPageHeading";
import MainTimeline from "../../components/MainTimeline/MainTimeline";
import styles from "./MainPage.module.scss";

const MainPage = () => {
  return (
    <main>
      <div className={styles.title}>Project name timeline</div>
      <div className={styles.header}>
        <MainPageHeading
          name={"Developers"}
          color={"#E3005F"}
          linkUrl={"/developers-note/new"}
        />
        <MainPageHeading
          name={"Client/Testers"}
          color={"#0471A6"}
          linkUrl={"clients-note/new"}
        />
      </div>
      <div>
        <MainTimeline />
      </div>
    </main>
  );
};

export default MainPage;
