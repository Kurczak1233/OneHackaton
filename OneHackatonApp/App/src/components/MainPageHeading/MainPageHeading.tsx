import styles from "./MainPageHeading.module.scss";

interface IMainPageHeading {
  name: string;
  color: string;
}

const MainPageHeading = ({ name, color }: IMainPageHeading) => {
  return (
    <div className={styles.sectionWrapper}>
      <div className={styles.sectionHeading} style={{ color: color }}>
        {name}
      </div>
      <div className={styles.colorBar} style={{ backgroundColor: color }} />
      <div className={styles.addButton} style={{ backgroundColor: color }}>
        Create new note
      </div>
    </div>
  );
};

export default MainPageHeading;
