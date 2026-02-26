using System;
using AssetContent;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	public class CollectionAprView : AprView
	{
		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDC")]
		public AprView View
		{
			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x8AEE", Offset = "0x8AEE", VA = "0x8AEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C20")]
		[Address(RVA = "0x8AEF", Offset = "0x8AEF", VA = "0x8AEF")]
		public void Init(CollectionsModel.AprMaterial data, UserData user, bool sameUser)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Collections_View_CollectionAprView__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57ea0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a57ea0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(param2 + 0x10),0);
		  }
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x8AF0", Offset = "0x8AF0", VA = "0x8AF0", Slot = "26")]
		protected override void SetAsset(AprDicWrapper data)
		{
		/* --- GHIDRA: SetAsset ---
		void Gameplay_Collections_View_CollectionAprView__SetAsset(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_View_AprView__SetGrayscale(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x8AF1", Offset = "0x8AF1", VA = "0x8AF1")]
		public CollectionAprView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionAprView___ctor
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int param1_00;
		  float param2_00;
		  ulonglong local_20;
		  ulonglong local_18;
		  ushort local_10;
		  ushort local_2;
		  
		  if (DAT_ram_00a57ea1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_Value__);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a57ea1 = '\x01';
		  }
		  local_2 = 0;
		  param1[0x14] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		            (param1,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(*param1 + 0x13c));
		  if (*(int *)(param2 + 0xc) != 0) {
		    _local_10 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_10,*(int *)(param2 + 0xc),Method_System_Nullable_int___ctor__);
		    local_18 = _local_10;
		    local_20 = _local_10;
		    Gameplay_Inventory_View_ArtikulView__get_StackSizeExternal(param1,&local_20,0);
		  }
		  param1_00 = param1[0x12];
		  iVar1 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		  System_Collections_Generic_List_object____ctor(iVar1,0);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor((int *)(param2 + 8),0);
		  *(undefined4 *)(iVar1 + 0x18) = uVar2;
		  if (DAT_ram_00a57ec6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    DAT_ram_00a57ec6 = '\x01';
		  }
		  _local_10 = _local_10 & 0xffffffffffff0000;
		  System_Data_SqlTypes_SqlByte__ToSqlInt64
		            (&local_10,(uint)(*(uint *)(param2 + 0xc) <= *(uint *)(param2 + 8)),
		             Method_System_Nullable_bool___ctor__);
		  *(ushort *)(iVar1 + 0x10) = local_10;
		  UI_Requirements_RequirementsView__GetRowPrefab(param1_00,iVar1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0x12],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param3,0);
		  if (param3 == 0) {
		    param2_00 = 1.0;
		  }
		  else {
		    param2_00 = 0.0;
		    if (*(int *)(param2 + 8) == 0) {
		      param2_00 = 1.0;
		    }
		  }
		  Gameplay_Inventory_View_ArtikulView__GetData(param1,param2_00,0);
		  iVar1 = param1[0x13];
		  if (*(char *)(param2 + 0x14) == '\0') {
		    uVar3 = 0;
		  }
		  else {
		    if (DAT_ram_00a57ec6 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		      DAT_ram_00a57ec6 = '\x01';
		    }
		    _local_10 = _local_10 & 0xffffffffffff0000;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64
		              (&local_10,(uint)(*(uint *)(param2 + 0xc) <= *(uint *)(param2 + 8)),
		               Method_System_Nullable_bool___ctor__);
		    local_2 = local_10;
		    uVar3 = UnityEngine_UI_RawImage__set_texture(&local_2,Method_System_Nullable_bool__get_Value__);
		    uVar3 = uVar3 ^ 1;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (iVar1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _rankFrame;

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _frameBgImage;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x68")]
		private AprView _view;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_Collections_View_CollectionAprView__get_View
		               (int param1,int param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  uint param2_00;
		  
		  if (DAT_ram_00a57e9f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57e9f = '\x01';
		  }
		  if (DAT_ram_00a57e9e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_AprView___);
		    DAT_ram_00a57e9e = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x68);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_AprView___);
		  }
		  *(int **)(param1 + 0x68) = piVar4;
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x138) * 4))
		            (piVar4,*(undefined4 *)(param2 + 8),*(undefined4 *)(*piVar4 + 0x13c));
		  uVar1 = 1;
		  iVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta(*(undefined4 *)(param2 + 0x10),0);
		  if ((iVar2 == 0) && (param4 != 0)) {
		    uVar1 = (uint)(*(char *)(param2 + 0x14) != '\0');
		  }
		  if (DAT_ram_00a57e9e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_AprView___);
		    DAT_ram_00a57e9e = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x68);
		  if (iVar2 == 0) {
		    iVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_AprView___);
		  }
		  *(int *)(param1 + 0x68) = iVar2;
		  if (param4 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(*(char *)(param2 + 0x14) != '\0');
		  }
		  Gameplay_Aprs_View_AprView__get_Achieved(iVar2,param2_00,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 100),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1 ^ 1,0);
		  if (uVar1 == 0) {
		    uVar3 = *(undefined4 *)(param2 + 0x10);
		    uVar5 = *(undefined4 *)(param1 + 100);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		    UI_Price_Price__SetColor(uVar5,param3,uVar3,0);
		  }
		  iVar2 = *(int *)(param2 + 0xc);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar2 == 0),0);
		  if (iVar2 != 0) {
		    uVar5 = *(undefined4 *)(param1 + 0x5c);
		    uVar3 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetFrameAssetId
		                      (*(undefined4 *)(param2 + 0xc),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar5,uVar3,0);
		  }
		  return;
		}
		*/

}
