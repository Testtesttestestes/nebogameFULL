using System;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class ClanLeagueBaseInfoView : MonoBehaviour
	{
		// Token: 0x06003CD3 RID: 15571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x8B96", Offset = "0x8B96", VA = "0x8B96")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_ClanLeagueBaseInfoView__Awake
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined8 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57efd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a57efd = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x10);
		  uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetTitle(*(undefined4 *)(param2 + 0x20),0);
		  iVar4 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		            (piVar3,CONCAT44(in_register_20000014,uVar1),*(undefined4 *)(iVar4 + 0xec));
		  iVar4 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		            (*(int **)(param1 + 0x18),
		             *(undefined4 *)(*(int *)(*(int *)(param2 + 0x1c) + 0x3c) + 0x10),
		             *(undefined4 *)(iVar4 + 0xe4));
		  uVar2 = func_ii_7271(*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x24),3,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  iVar4 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		            (*(int **)(param1 + 0x14),uVar2,*(undefined4 *)(iVar4 + 0xe4));
		  Core_Extensions_Dict_UserRatingKindDicExt__GetIcon32AssetId
		            (*(undefined4 *)(param1 + 0x14),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x8B97", Offset = "0x8B97", VA = "0x8B97")]
		public void UpdateInfo(ClanData data, string honorAssetId)
		{
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x8B98", Offset = "0x8B98", VA = "0x8B98")]
		public ClanLeagueBaseInfoView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_View_ClanLeagueBaseInfoView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57efe == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12597);
		    DAT_ram_00a57efe = '\x01';
		  }
		  return StringLiteral_12597;
		}
		*/

		}

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _leagueName;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TitleIconValueBackground _honor;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleIconValueBackground _place;
	}
}
