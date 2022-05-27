const MainTimelineLogic = () => {
  const mockedData = [
    {
      date: "27-05-2022",
      developersItems: [
        { id: 1, name: "bug request" },
        { id: 2, name: "bug report" },
      ],
      usersItems: [
        { id: 3, name: "bug request" },
        { id: 4, name: "bug report" },
      ],
    },
    {
      date: "26-05-2022",
      developersItems: [{ id: 5, name: "bug request" }],
      usersItems: [
        { id: 6, name: "bug request" },
        { id: 7, name: "bug bbbb" },
        { id: 8, name: "bug aaaa" },
      ],
    },
    {
      date: "25-05-2022",
      developersItems: [{ id: 9, name: "bug request" }],
      usersItems: [
        { id: 10, name: "bug request" },
        { id: 11, name: "bug report" },
      ],
    },
    {
      date: "24-05-2022",
      developersItems: [{ id: 12, name: "bug request" }],
      usersItems: [
        { id: 13, name: "bug request" },
        { id: 14, name: "bug report" },
      ],
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
