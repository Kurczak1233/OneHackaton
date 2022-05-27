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
            <div className={styles.itemWrapper} key={item.date.toString()}>
              <ClientItems usersItems={item.usersItems} />
              <div
                style={{
                  height:
                    100 * getBiggerValue(item.developersItems, item.usersItems),
                }}
                className={styles.middleDayBar}
              />
              <DevelopersItems developersItems={item.developersItems} />
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default MainTimeline;
