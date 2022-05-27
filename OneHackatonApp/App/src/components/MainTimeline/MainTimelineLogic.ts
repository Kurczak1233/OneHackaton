const MainTimelineLogic = () => {
  const mockedData = [
    {
      date: "27-05-2022",
      developersItems: [{ name: "bug request" }, { name: "bug report" }],
      usersItems: [{ name: "bug request" }, { name: "bug report" }],
    },
    {
      date: "26-05-2022",
      developersItems: [{ name: "bug request" }],
      usersItems: [{ name: "bug request" }, { name: "bug report" }],
    },
    {
      date: "25-05-2022",
      developersItems: [{ name: "bug request" }],
      usersItems: [{ name: "bug request" }, { name: "bug report" }],
    },
    {
      date: "24-05-2022",
      developersItems: [{ name: "bug request" }],
      usersItems: [{ name: "bug request" }, { name: "bug report" }],
    },
  ];

  const getBiggerValue = (
    items: {
      name: string;
    }[],
    otherItems: {
      name: string;
    }[]
  ) => {
    return items.length > otherItems.length ? items.length : otherItems.length;
  };

  return { mockedData, getBiggerValue };
};

export default MainTimelineLogic;
