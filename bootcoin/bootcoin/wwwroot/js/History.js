let history = {
  compareString: (x, y) => {
    if (x < y) return -1;
    else if (x > y) return 1;
    else return 0;
  },

  compareNumber: (x, y) => {
    x = new Number(x);
    y = new Number(y);

    if (x < y) return -1;
    else if (x > y) return 1;
    else return 0;
  },

  compareDate: (x, y) => {
    x = new Date(x);
    y = new Date(y);

    if (x < y) return -1;
    else if (x > y) return 1;
    else return 0;
  },

  fetchEntries: () => {
    let _entries = [];

    let _rowDOM = document.querySelectorAll(".history .entry");

    _rowDOM.forEach((row) => {
      let _columns = [];

      let _columnDOM = row.querySelectorAll("td");

      _columnDOM.forEach((column) => {
        _columns.push(column.textContent);
      });

      _entries.push(_columns);
    });

    return _entries;
  },

  overwriteEntries: (entries) => {
    let _rowDOM = document.querySelectorAll(".history .entry");

    _rowDOM.forEach((row) => {
      let _columns = entries.shift();

      let _columnDOM = row.querySelectorAll("td");

      _columnDOM.forEach((column) => {
        column = column.querySelector("span");
        column.textContent = _columns.shift();
      });
    });
  },

  getStatus: (column) => {
    let _headerDOM = document.querySelectorAll(".history .head th .legend");

    let _classList = _headerDOM[column - 1].classList;

    if (_classList.contains("descending")) return 2;
    else if (_classList.contains("ascending")) return 1;
    else return 0;
  },

  reset: () => {
    let _headerDOM = document.querySelectorAll(".history .head th .legend");

    _headerDOM.forEach((header) => {
      header.classList.remove("ascending", "descending");

      let icon = header.querySelector("img[alt='sort']");
      icon.setAttribute("src", "/icons/table-sort.svg");
    });
  },

  rotateStatus: (column, current) => {
    let _headerDOM = document.querySelectorAll(".history .head th .legend");
    let icon = _headerDOM[column - 1].querySelector("img[alt='sort']");

    if (current == 0) {
      _headerDOM[column - 1].classList.add("ascending");
      icon.setAttribute("src", "/icons/table-sort-ascending.svg");
    } else if (current == 1) {
      _headerDOM[column - 1].classList.add("descending");
      icon.setAttribute("src", "/icons/table-sort-descending.svg");
    } else if (current == 2) {
      history.reset();
    }
  },

  sortTrigger: (column) => {
    let _entries = history.fetchEntries();

    let _method;
    switch (column) {
      case 1:
        _method = history.compareDate;
        break;
      case 2:
        _method = history.compareString;
        break;
      case 3:
        _method = history.compareString;
        break;
      case 4:
        _method = history.compareNumber;
        break;
      case 5:
        _method = history.compareNumber;
        break;
      default:
        break;
    }

    let _status = history.getStatus(column);

    if (_status == 0) {
      history.reset();
      _entries.sort((x, y) => {
        return _method(x[column - 1], y[column - 1]);
      });
    } else if (_status == 1) {
      _entries.reverse((x, y) => {
        return _method(x[column - 1], y[column - 1]);
      });
    } else if (_status == 2) {
      _entries = JSON.parse(JSON.stringify(history.origin));
    }

    history.rotateStatus(column, _status);

    history.overwriteEntries(_entries);
  },

  origin,
};

history.origin = history.fetchEntries();
