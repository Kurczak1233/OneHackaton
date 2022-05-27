import MainTimelineLogic from "./MainTimelineLogic";
import styles from "./MainTimeline.module.scss";
import { dateDashesFormat } from "../../consts/dateDashesFormat";
import { format } from "date-fns";
import DevelopersItems from "../DevelopersItems/DevelopersItems";
import ClientItems from "../ClientItems/ClientItems";

const MainTimeline = () => {
  const { mockedData, getBiggerValue } = MainTimelineLogic();
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
        {mockedData.map((item) => {
          return (
            <div key={item.date.toString()}>
              <div className={styles.itemWrapper}>
                <DevelopersItems developersItems={item.developersItems} />
                <div
                  style={{
                    height:
                      125 *
                      getBiggerValue(item.developersItems, item.usersItems),
                  }}
                  className={styles.middleDayBar}
                />
                <ClientItems usersItems={item.usersItems} />
              </div>
              <div className={styles.daySeparationBarWrapper}>
                <div className={styles.daySeparationBar}>
                  <span className={styles.dayDate}>{item.date}</span>
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
