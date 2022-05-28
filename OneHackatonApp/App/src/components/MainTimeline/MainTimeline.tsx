import MainTimelineLogic from "./MainTimelineLogic";
import styles from "./MainTimeline.module.scss";
import { dateDashesFormat } from "../../consts/dateDashesFormat";
import { compareDesc, format } from "date-fns";
import DevelopersItems from "../DevelopersItems/DevelopersItems";
import ClientItems from "../ClientItems/ClientItems";

const MainTimeline = () => {
  const { timeline, getBiggerValue } = MainTimelineLogic();
  console.log(timeline);
  if (!timeline) {
    return <div />;
  }
  return (
    <div>
      <div className={styles.dotWrapper}>
        <div className={styles.todayDate}>
          {format(new Date(), dateDashesFormat)}
        </div>
      </div>
      <div className={styles.dotWrapper}>
        <div className={styles.dot} />
      </div>
      <div>
        {timeline
          .sort((item, item2) =>
            compareDesc(new Date(item.date), new Date(item2.date))
          )
          .map((item) => {
            return (
              <div key={item.date.toString()}>
                <div className={styles.itemWrapper}>
                  <DevelopersItems developersItems={item.developerItems} />
                  <div
                    style={{
                      height:
                        125 *
                        getBiggerValue(item.developerItems, item.userItems),
                    }}
                    className={styles.middleDayBar}
                  />
                  <ClientItems usersItems={item.userItems} />
                </div>
                <div className={styles.daySeparationBarWrapper}>
                  <div className={styles.daySeparationBar}>
                    <span className={styles.dayDate}>
                      {format(new Date(item.date), dateDashesFormat)}
                    </span>
                  </div>
                </div>
              </div>
            );
          })}
      </div>
    </div>
  );
};

export default MainTimeline;
