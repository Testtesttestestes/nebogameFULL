using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.UserInfo.View;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Schedule
{
	// Token: 0x020002EF RID: 751
	[Token(Token = "0x20002EF")]
	[Serializable]
	public class MyRatingRender
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x63CA", Offset = "0x63CA", VA = "0x63CA")]
		public void Render(IList<WorldAxisOfficeModel.ColossusClanRating> clanRatings, UserData user)
		{
		/* --- GHIDRA: Render ---
		void Gameplay_WorldAxis_Office_View_Schedule_MyRatingRender__Render(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_Schedule_ColossusRatingRender_TypeInfo);
		    DAT_ram_00a58b96 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Office_View_Schedule_ColossusRatingRender_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x63CB", Offset = "0x63CB", VA = "0x63CB")]
		public MyRatingRender()
		{
		}

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private TitleIconValueBackground _myClan;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private TextMeshProUGUI _myClanPlace;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x10")]
		private ColossusRatingRender _render;
	}
}
