﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExcelLibrary.Office.Excel
{
	public partial class ARRAY : Record
	{
		public ARRAY(Record record) : base(record) { }

		public ARRAY()
		{
			this.Type = RecordType.ARRAY;
		}

	}
}