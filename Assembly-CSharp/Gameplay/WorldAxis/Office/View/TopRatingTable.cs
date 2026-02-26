using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.UserInfo.View;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	public class TopRatingTable : MonoBehaviour
	{
		// Token: 0x060011B9 RID: 4537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x63B6", Offset = "0x63B6", VA = "0x63B6")]
		public void Init(IList<WorldAxisOfficeModel.ColossusClanRating> clanRatings, UserData user)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_Office_View_TopRatingTable__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_Schedule_ColossusRatingRender_TypeInfo);
		    DAT_ram_00a58b8c = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Office_View_Schedule_ColossusRatingRender_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x63B7", Offset = "0x63B7", VA = "0x63B7")]
		public TopRatingTable()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_WorldAxis_Office_View_TopRatingTable___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b8d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12687);
		    DAT_ram_00a58b8d = '\x01';
		  }
		  return StringLiteral_12687;
		}
		*/

		}

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground[] _top3;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MyRatingRender _myRating;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x18")]
		private ColossusRatingRender _render;
	}
}
