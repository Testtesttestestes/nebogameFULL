using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class GameBgCanvas : MonoBehaviour
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5BF8", Offset = "0x5BF8", VA = "0x5BF8")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_GameBgCanvas__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b877 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a5b877 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x18),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5BF9", Offset = "0x5BF9", VA = "0x5BF9")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_GameBgCanvas__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b878 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_GameBgCanvas_ValidateSize__);
		    DAT_ram_00a5b878 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x10) + 0x80) != 0) {
		    piVar3 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar5 = *piVar3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                      (piVar3,*(undefined4 *)(iVar5 + 0xe4));
		    *(undefined4 *)(param1 + 0x28) = uVar2;
		    piVar3 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar5 = *piVar3;
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                      (piVar3,*(undefined4 *)(iVar5 + 0xf4));
		    *(undefined4 *)(param1 + 0x2c) = uVar2;
		  }
		  UI_GameBgCanvas__Apply(param1,param1);
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  iVar5 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener(uVar2,param1,Method_UI_GameBgCanvas_ValidateSize__,0);
		  if (DAT_ram_00a5b809 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b809 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x10);
		  while ((piVar3 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0), piVar3 == (int *)0x0
		         || (System_Action_TypeInfo == *piVar3))) {
		    iVar4 = func_ii_4329(iVar5 + 0x10,piVar3,param1_00);
		    bVar1 = iVar4 == param1_00;
		    param1_00 = iVar4;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(piVar3,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x5BFA", Offset = "0x5BFA", VA = "0x5BFA")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_GameBgCanvas__Start(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (*(int *)(*(int *)(param1 + 0x10) + 0x80) != 0) {
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar3 = *piVar2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		                      (piVar2,*(undefined4 *)(iVar3 + 0xe4));
		    *(undefined4 *)(param1 + 0x28) = uVar1;
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar3 = *piVar2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf0) * 4))
		                      (piVar2,*(undefined4 *)(iVar3 + 0xf4));
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x5BFB", Offset = "0x5BFB", VA = "0x5BFB")]
		private void Apply()
		{
		/* --- GHIDRA: Apply ---
		void UI_GameBgCanvas__Apply(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  float fVar3;
		  ulonglong local_30;
		  undefined8 local_28;
		  float4 local_20;
		  undefined4 local_1c;
		  float4 local_18;
		  undefined4 local_14;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  float4 local_4;
		  
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x1c),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (auStack_10,*(undefined4 *)(param1 + 0x1c),0);
		  fVar3 = (float)*(int *)(param1 + 0x28);
		  local_18 = (float4)((float)local_8 / fVar3);
		  local_14 = 0x3f800000;
		  local_28 = CONCAT44(0x3f800000,local_18);
		  local_1c = 0;
		  local_20 = (float4)((((float)local_8 - fVar3) * -0.5) / fVar3);
		  local_30 = (ulonglong)(uint)local_20;
		  UnityEngine_UI_RawImage__get_uvRect(*(undefined4 *)(param1 + 0x10),&local_30,0);
		  iVar2 = *(int *)(param1 + 0x2c);
		  if ((float)local_4 <= (float)iVar2) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  else {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    fVar3 = ((float)local_4 - (float)iVar2) * 0.5 + 20.0;
		    UnityEngine_RectTransform__GetWorldCorners(*(undefined4 *)(param1 + 0x20),1,fVar3,0);
		    UnityEngine_RectTransform__GetWorldCorners(*(undefined4 *)(param1 + 0x24),1,fVar3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x5BFC", Offset = "0x5BFC", VA = "0x5BFC")]
		private void ValidateSize()
		{
		/* --- GHIDRA: ValidateSize ---
		void UI_GameBgCanvas__ValidateSize(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  *(undefined4 *)(param1 + 0x30) = param2;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		            (*(undefined4 *)(param1 + 0x10),param2,0);
		  if (*(int *)(*(int *)(param1 + 0x10) + 0x80) != 0) {
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar3 = *piVar2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		                      (piVar2,*(undefined4 *)(iVar3 + 0xe4));
		    *(undefined4 *)(param1 + 0x28) = uVar1;
		    piVar2 = *(int **)(*(int *)(param1 + 0x10) + 0x80);
		    iVar3 = *piVar2;
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf0) * 4))
		                      (piVar2,*(undefined4 *)(iVar3 + 0xf4));
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  UI_GameBgCanvas__Apply(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x5BFD", Offset = "0x5BFD", VA = "0x5BFD")]
		public void SetTexture(Texture2D value)
		{
		/* --- GHIDRA: SetTexture ---
		undefined4 UI_GameBgCanvas__SetTexture(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x80);
		}
		*/

		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x5BFE", Offset = "0x5BFE", VA = "0x5BFE")]
		public Texture GetTexture()
		{
			return null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x5BFF", Offset = "0x5BFF", VA = "0x5BFF")]
		public GameBgCanvas()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_GameBgCanvas___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    DAT_ram_00a5b879 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    return *(undefined4 *)(param1 + 0x10);
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return uVar1;
		}
		*/

		}

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImage _bgImage;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImage _topSolid;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RawImage _bottomSolid;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _topSolidRectTransform;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x24")]
		private RectTransform _bottomSolidRectTransform;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x28")]
		private int _bgTextureWidth;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x2C")]
		private int _bgTextureHeight;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x30")]
		private Texture _customTexture;
	}
}
