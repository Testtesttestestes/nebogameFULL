using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Elements.RatingElements
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public class TopLeaders : MonoBehaviour
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x6045", Offset = "0x6045", VA = "0x6045")]
		public void Init(IEnumerable<UserData> users)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeaders__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63973 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Skip_CultDic___);
		    DAT_ram_00a63973 = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (param2,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x10),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,1,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x14),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,2,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x18),uVar1,uVar1);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeaders__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63973 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Skip_CultDic___);
		    DAT_ram_00a63973 = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (param2,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x10),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,1,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x14),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,2,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x18),uVar1,uVar1);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeaders__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63973 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Skip_CultDic___);
		    DAT_ram_00a63973 = '\x01';
		  }
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (param2,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x10),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,1,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x14),uVar1,param2);
		  uVar1 = System_Linq_Enumerable__SingleOrDefault___Il2CppFullySharedGenericType_
		                    (param2,2,Method_System_Linq_Enumerable_Skip_CultDic___);
		  uVar1 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (uVar1,Method_System_Linq_Enumerable_FirstOrDefault_CultDic___);
		  UI_Elements_RatingElements_TopLeader__Init(*(undefined4 *)(param1 + 0x18),uVar1,uVar1);
		  return;
		}
		*/

		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x6046", Offset = "0x6046", VA = "0x6046")]
		public void Init(IEnumerable<ClanData> clans, Action<ClanData> callback)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x6047", Offset = "0x6047", VA = "0x6047")]
		public void Init(IEnumerable<CultDic> cults)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x6048", Offset = "0x6048", VA = "0x6048")]
		public TopLeaders()
		{
		/* --- GHIDRA: .ctor ---
		uint UI_Elements_RatingElements_TopLeaders___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63974 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_SubRatingListElementArgs__get_Selected__
		              );
		    DAT_ram_00a63974 = '\x01';
		  }
		  return (uint)*(byte *)(param1 + 0x1d);
		}
		*/

		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TopLeader _firstLeader;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TopLeader _secondLeader;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TopLeader _thirdLeader;
	}
}
