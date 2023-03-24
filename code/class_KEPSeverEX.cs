using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using OPCAutomation; // Thư viện OPC


namespace Picturebox
{
    public static class class_KEPSeverEXs
    {
		public static string[] tagread(int tagnumber)
		{
			string tagID_1 = "Channel1.Device1.M_Mode";
			string tagID_2 = "Channel1.Device1.M_Start";
			string tagID_3 = "Channel1.Device1.M_Stop";
			string tagID_4 = "Channel1.Device1.Q_lamp_Auto";
			string tagID_5 = "Channel1.Device1.Q_lamp_Manu";
			string tagID_6 = "Channel1.Device1.Set_Me_Tron";
			string tagID_7 = "Channel1.Device1.Set_Time_Tron_1";
			string tagID_8 = "Channel1.Device1.Set_Time_Tron_2";
			string tagID_9 = "Channel1.Device1.Set_Weight_Cat";
			string tagID_10 = "Channel1.Device1.Set_Weight_PG1";
			string tagID_11 = "Channel1.Device1.Set_Weight_PG2";
			string tagID_12 = "Channel1.Device1.Set_Weight_Tro_khoang";
			string tagID_13 = "Channel1.Device1.Set_Weight_XM";
			string tagID_14 = "Channel1.Device1.Q_Lamp_Fault";
			string tagID_15 = "Channel1.Device1.TG_DK_VH";
			string tagID_16 = "Channel1.Device1.TG_Btt_Simulation";
			string tagID_17 = "Channel1.Device1.Status_V1_Tro_khoang";
			string tagID_18 = "Channel1.Device1.Status_V2_Tro_khoang";
			string tagID_19 = "Channel1.Device1.Status_V1_cat";
			string tagID_20 = "Channel1.Device1.Status_V2_cat";
			string tagID_21 = "Channel1.Device1.Status_V1_PG1";
			string tagID_22 = "Channel1.Device1.Status_V2_PG1";
			string tagID_23 = "Channel1.Device1.Status_V1_PG2";
			string tagID_24 = "Channel1.Device1.Status_V2_PG2";
			string tagID_25 = "Channel1.Device1.Status_V1_Xm";
			string tagID_26 = "Channel1.Device1.Status_V2_Xm";
			string tagID_27 = "Channel1.Device1.Status_Bt";
			string tagID_28 = "Channel1.Device1.Status_DC";
			string tagID_29 = "Channel1.Device1.Status_VX";
			string tagID_30 = "Channel1.Device1.TG_Done_Chu_Trinh";
			string tagID_31 = "Channel1.Device1.Act_Weight_Cat";
			string tagID_32 = "Channel1.Device1.Act_Weight_PG_1";
			string tagID_33 = "Channel1.Device1.Act_Weight_PG_2";
			string tagID_34 = "Channel1.Device1.Act_Weight_Tro_khoang";
			string tagID_35 = "Channel1.Device1.Act_Weight_XM";
			string tagID_36 = "Channel1.Device1.Act_Me_Tron";
			string tagID_37 = "Channel1.Device1.M_SW_V1_Tro_khoang";
			string tagID_38 = "Channel1.Device1.M_SW_V1_Tro_khoang";
			string tagID_39 = "Channel1.Device1.Q_Manu_V1_D";
			string tagID_40 = "Channel1.Device1.M_SW_BT";
			string tagID_41 = "Channel1.Device1.M_SW_BT";
			string tagID_42 = "Channel1.Device1.Q_Manu_BT";
			string tagID_43 = "Channel1.Device1.M_SW_TRON";
			string tagID_44 = "Channel1.Device1.M_SW_TRON";
			string tagID_45 = "Channel1.Device1.Q_Manu_TRON";
			string tagID_46 = "Channel1.Device1.M_SW_VX";
			string tagID_47 = "Channel1.Device1.M_SW_VX";
			string tagID_48 = "Channel1.Device1.Q_Manu_VX";
			string tagID_49 = "Channel1.Device1.M_SW_XILO_XM";
			string tagID_50 = "Channel1.Device1.M_SW_XILO_XM";
			string tagID_51 = "Channel1.Device1.Q_Manu_XILO_XM";
			string tagID_52 = "Channel1.Device1.Q_Manu_V1_D";
			string tagID_53 = "Channel1.Device1.sql_OrderID";

			string[] tags;
			tags = new string[tagnumber];
			tags.SetValue(tagID_1, 1);
			tags.SetValue(tagID_2, 2);
			tags.SetValue(tagID_3, 3);
			tags.SetValue(tagID_4, 4);
			tags.SetValue(tagID_5, 5);
			tags.SetValue(tagID_6, 6);
			tags.SetValue(tagID_7, 7);
			tags.SetValue(tagID_8, 8);
			tags.SetValue(tagID_9, 9);
			tags.SetValue(tagID_10, 10);
			tags.SetValue(tagID_11, 11);
			tags.SetValue(tagID_12, 12);
			tags.SetValue(tagID_13, 13);
			tags.SetValue(tagID_14, 14);
			tags.SetValue(tagID_15, 15);
			tags.SetValue(tagID_16, 16);
			tags.SetValue(tagID_17, 17);
			tags.SetValue(tagID_18, 18);
			tags.SetValue(tagID_19, 19);
			tags.SetValue(tagID_20, 20);
			tags.SetValue(tagID_21, 21);
			tags.SetValue(tagID_22, 22);
			tags.SetValue(tagID_23, 23);
			tags.SetValue(tagID_24, 24);
			tags.SetValue(tagID_25, 25);
			tags.SetValue(tagID_26, 26);
			tags.SetValue(tagID_27, 27);
			tags.SetValue(tagID_28, 28);
			tags.SetValue(tagID_29, 29);
			tags.SetValue(tagID_30, 30);
			tags.SetValue(tagID_31, 31);
			tags.SetValue(tagID_32, 32);
			tags.SetValue(tagID_33, 33);
			tags.SetValue(tagID_34, 34);
			tags.SetValue(tagID_35, 35);
			tags.SetValue(tagID_36, 36);
			tags.SetValue(tagID_37, 37);
			tags.SetValue(tagID_38, 38);
			tags.SetValue(tagID_39, 39);
			tags.SetValue(tagID_39, 39);
			tags.SetValue(tagID_40, 40);
			tags.SetValue(tagID_41, 41);
			tags.SetValue(tagID_42, 42);
			tags.SetValue(tagID_43, 43);
			tags.SetValue(tagID_44, 44);
			tags.SetValue(tagID_45, 45);
			tags.SetValue(tagID_46, 46);
			tags.SetValue(tagID_47, 47);
			tags.SetValue(tagID_48, 48);
			tags.SetValue(tagID_49, 49);
			tags.SetValue(tagID_50, 50);
			tags.SetValue(tagID_51, 51);
			tags.SetValue(tagID_52, 52);
			tags.SetValue(tagID_53, 53);

			return tags;
		}
		// Class tạo array đọc ID tags - mặc định không đổi
		public static Int32[] tagID(int tagnumber)
		{
			Int32[] cltarr;
			cltarr = new Int32[tagnumber];
			for (int i = 1; i < tagnumber; i++)
			{
				cltarr.SetValue(i, i);
			}
			return cltarr;
		}
	}
}
