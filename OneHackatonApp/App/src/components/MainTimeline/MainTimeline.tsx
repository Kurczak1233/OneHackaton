import MainTimelineLogic from "./MainTimelineLogic";
import styles from "./MainTimeline.module.scss";
const MainTimeline = () => {
  const { mockedData } = MainTimelineLogic();
  return (
    <div>
      <div>27.02.50</div>
      <div>Dot</div>
      <div>
        {mockedData.map((item) => {
          return (
            <div className={styles.itemWrapper} key={item.date.toString()}>
              <div>Developers items</div>
              <div
                style={{ height: 100 * item.items.length }}
                className={styles.middleDayBar}
              />
              <div>Clients items</div>
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default MainTimeline;
