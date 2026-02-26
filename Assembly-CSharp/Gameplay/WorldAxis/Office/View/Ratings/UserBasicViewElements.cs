using System;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[Serializable]
	public class UserBasicViewElements
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x6427", Offset = "0x6427", VA = "0x6427")]
		public void AssignAssets(UserData userData)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x6428", Offset = "0x6428", VA = "0x6428")]
		public UserBasicViewElements()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_UserBasicViewElements___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined8 uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  undefined8 in_i2q;
		  undefined8 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  uint *puVar7;
		  longlong lVar8;
		  undefined4 uVar9;
		  undefined4 *puVar10;
		  int iVar11;
		  int iVar12;
		  int *param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar13;
		  undefined8 uVar14;
		  int *piVar15;
		  
		  uVar1 = (uint)((ulonglong)in_i2q >> 0x20);
		  iVar13 = 0;
		  if (DAT_ram_00a58bb6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_BattleHistoryListElement_BattleHistoryListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58bb6 = '\x01';
		  }
		  Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement__ApplyArgs
		            (param1,*(undefined4 *)(param1 + 0x18),0);
		  uVar9 = *(undefined4 *)(param1 + 0x24);
		  uVar5 = Core_Extensions_Dict_CollectionsDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(param1 + 0x18) + 0x20),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar9,uVar5,0);
		  uVar5 = *(undefined4 *)(param1 + 0x38);
		  uVar14 = *(undefined8 *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x18);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  uVar6 = Utils_TimeUtils__DateFormat(uVar14,0);
		  uVar9 = (undefined4)((ulonglong)uVar14 >> 0x20);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar5,uVar6,0);
		  AssetContent_GameImage__get_AssetId
		            (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(*(int *)(param1 + 0x18) + 0x24),0);
		  AssetContent_GameImage__get_AssetId
		            (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(*(int *)(param1 + 0x18) + 0x28),0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x30),
		             *(undefined4 *)
		              (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x24) + 0xc) + 0x18),0);
		  UnityEngine_Component__GetComponentInChildren_object_
		            (*(undefined4 *)(param1 + 0x34),
		             *(undefined4 *)
		              (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x28) + 0xc) + 0x18),0);
		  lVar8 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 0x18) + 0x30),0);
		  if (lVar8 == *(longlong *)
		                (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x24) + 0xc) + 0x10))
		  {
		    uVar5 = *(undefined4 *)(param1 + 0x44);
		    puVar10 = (undefined4 *)(param1 + 0x4c);
		  }
		  else {
		    lVar8 = Core_Data_UserData___ctor(*(undefined4 *)(*(int *)(param1 + 0x18) + 0x30),0);
		    uVar5 = *(undefined4 *)(param1 + 0x44);
		    puVar10 = (undefined4 *)(param1 + 0x50);
		    if (*(longlong *)
		         (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x1c) + 0x28) + 0xc) + 0x10) != lVar8
		       ) {
		      puVar10 = (undefined4 *)(param1 + 0x48);
		    }
		  }
		  uVar14 = CONCAT44(in_register_20000014,*puVar10);
		  lVar8 = (ulonglong)uVar1 << 0x20;
		  func_ii_7050(uVar5,*puVar10,0);
		  iVar11 = *(int *)(*(int *)(param1 + 0x18) + 0x2c);
		  if (0 < *(int *)(iVar11 + 0xc)) {
		    iVar12 = *(int *)(*(int *)(param1 + 0x18) + 0x1c);
		    param1_00 = *(int **)(*(int *)(iVar12 + 0x28) + 0x10);
		    param1_01 = *(int **)(*(int *)(iVar12 + 0x24) + 0x10);
		    do {
		      uVar6 = (undefined4)((ulonglong)lVar8 >> 0x20);
		      uVar5 = (undefined4)((ulonglong)uVar14 >> 0x20);
		      iVar11 = *(int *)(*(int *)(iVar11 + iVar13 * 4 + 0x10) + 0xc) + -1;
		      param1_02 = *(undefined4 *)(*(int *)(param1 + 0x54) + iVar13 * 4 + 0x10);
		      iVar12 = *param1_01;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar15 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar15) {
		            puVar7 = (uint *)(iVar12 + piVar15[1] * 8 + 0xc0);
		            goto code_r0x80f826de;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar7 = (uint *)func_ii_1080(param1_01,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f826de:
		      uVar2 = CONCAT44(uVar9,param1_01);
		      uVar3 = CONCAT44(uVar5,iVar11);
		      uVar4 = CONCAT44(uVar6,puVar7[1]);
		      uVar14 = (**(code **)((ulonglong)*puVar7 * 4))(uVar2,uVar3,uVar4);
		      uVar6 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      uVar9 = (undefined4)((ulonglong)uVar3 >> 0x20);
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      iVar12 = *param1_00;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar15 = (int *)(*(int *)(iVar12 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar15) {
		            puVar7 = (uint *)(iVar12 + piVar15[1] * 8 + 0xc0);
		            goto code_r0x80f8275e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar1);
		      }
		      puVar7 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x80f8275e:
		      uVar2 = CONCAT44(uVar5,param1_00);
		      lVar8 = (**(code **)((ulonglong)*puVar7 * 4))
		                        (uVar2,CONCAT44(uVar9,iVar11),CONCAT44(uVar6,puVar7[1]));
		      uVar9 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      Gameplay_WorldAxis_Office_View_History_ValueIconTitleValue__SetIcon
		                (param1_02,uVar14,lVar8,puVar7);
		      iVar13 = iVar13 + 1;
		      iVar11 = *(int *)(*(int *)(param1 + 0x18) + 0x2c);
		    } while (iVar13 < *(int *)(iVar11 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickname;
	}
}
