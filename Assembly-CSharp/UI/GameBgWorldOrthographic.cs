using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[RequireComponent(typeof(SpriteRenderer))]
	public class GameBgWorldOrthographic : MonoBehaviour
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000105")]
		private SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x5C00", Offset = "0x5C00", VA = "0x5C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x5C01", Offset = "0x5C01", VA = "0x5C01")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_GameBgWorldOrthographic__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5b87b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_GameBgWorldOrthographic_InstanceOnGameContentScaledEvent__);
		    DAT_ram_00a5b87b = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  iVar2 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,Method_UI_GameBgWorldOrthographic_InstanceOnGameContentScaledEvent__,0
		            );
		  if (DAT_ram_00a5b809 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b809 = '\x01';
		  }
		  param1_00 = *(int *)(iVar2 + 0x10);
		  while ((param1_02 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0),
		         param1_02 == (int *)0x0 || (System_Action_TypeInfo == *param1_02))) {
		    param2_00 = func_ii_4329(iVar2 + 0x10,param1_02,param1_00);
		    bVar1 = param2_00 == param1_00;
		    param1_00 = param2_00;
		    if (bVar1) {
		      UI_GameBgWorldOrthographic__InstanceOnGameContentScaledEvent(param1,param2_00);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x5C02", Offset = "0x5C02", VA = "0x5C02")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_GameBgWorldOrthographic__Start(undefined4 param1,undefined4 param2)
		
		{
		  UI_GameBgWorldOrthographic__InstanceOnGameContentScaledEvent(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x5C03", Offset = "0x5C03", VA = "0x5C03")]
		private void InstanceOnGameContentScaledEvent()
		{
		/* --- GHIDRA: InstanceOnGameContentScaledEvent ---
		void UI_GameBgWorldOrthographic__InstanceOnGameContentScaledEvent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  double dVar4;
		  int iVar5;
		  float fVar6;
		  int iVar7;
		  ulonglong uVar8;
		  undefined8 local_20;
		  float4 local_18;
		  undefined4 local_14;
		  float8 local_10;
		  float4 local_8;
		  
		  iVar1 = UnityEngine_RefreshRate__ToString(0);
		  if (DAT_ram_00a5b879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    DAT_ram_00a5b879 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar2 = func_ii_6601(uVar2,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		  }
		  uVar2 = func_ii_7884(uVar2,0);
		  UnityEngine_Sprite__get_bounds(&local_10,uVar2,0);
		  if (ABS((float)local_8) < 2.1474836e+09) {
		    iVar5 = (int)(float)local_8;
		  }
		  else {
		    iVar5 = -0x80000000;
		  }
		  iVar1 = iVar1 / iVar5;
		  dVar4 = unnamed_function_4206((double)iVar1,&local_10);
		  if (iVar1 < 0) {
		    if (dVar4 == -0.5) {
		      if (ABS((double)local_10) < 9.223372036854776e+18) {
		        uVar8 = (ulonglong)(double)local_10;
		      }
		      else {
		        uVar8 = 0;
		      }
		      fVar6 = (float)(double)local_10;
		      if ((uVar8 & 1) != 0) {
		        fVar6 = (float)(double)local_10 + -1.0;
		      }
		    }
		    else {
		      fVar6 = CEIL((float)iVar1 + -0.5);
		    }
		  }
		  else if (dVar4 == 0.5) {
		    if (ABS((double)local_10) < 9.223372036854776e+18) {
		      uVar8 = (ulonglong)(double)local_10;
		    }
		    else {
		      uVar8 = 0;
		    }
		    fVar6 = (float)(double)local_10;
		    if ((uVar8 & 1) != 0) {
		      fVar6 = (float)(double)local_10 + 1.0;
		    }
		  }
		  else {
		    fVar6 = FLOOR((float)iVar1 + 0.5);
		  }
		  if (ABS(fVar6) < 2.1474836e+09) {
		    iVar1 = (int)fVar6;
		  }
		  else {
		    iVar1 = -0x80000000;
		  }
		  iVar3 = Utils_MathUtils_MathUtils__SaferDivide(-iVar1,3,0);
		  if (DAT_ram_00a5b879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    DAT_ram_00a5b879 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar2 = func_ii_6601(uVar2,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		  }
		  else {
		    uVar2 = *(undefined4 *)(param1 + 0x10);
		  }
		  local_14 = 0x44800000;
		  iVar7 = 3;
		  if (3 < iVar1 + iVar3) {
		    iVar7 = iVar1 + iVar3;
		  }
		  local_18 = (float4)(float)(iVar7 * iVar5);
		  local_20 = CONCAT44(0x44800000,local_18);
		  UnityEngine_SpriteRenderer__get_size(uVar2,&local_20,0);
		  return;
		}
		*/

		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x5C04", Offset = "0x5C04", VA = "0x5C04")]
		private void ValidateSize()
		{
		/* --- GHIDRA: ValidateSize ---
		undefined4 UI_GameBgWorldOrthographic__ValidateSize(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    DAT_ram_00a5b879 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x10) = uVar1;
		  }
		  else {
		    uVar1 = *(undefined4 *)(param1 + 0x10);
		  }
		  uVar1 = func_ii_7884(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x5C05", Offset = "0x5C05", VA = "0x5C05")]
		public Sprite GetSprite()
		{
		/* --- GHIDRA: GetSprite ---
		void UI_GameBgWorldOrthographic__GetSprite(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    DAT_ram_00a5b879 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_SpriteRenderer___);
		    *(undefined4 *)(param1 + 0x10) = uVar1;
		  }
		  else {
		    uVar1 = *(undefined4 *)(param1 + 0x10);
		  }
		  Core_Extensions_SpriteAtlasExt__TryGetSprite(uVar1,param2,0);
		  UI_GameBgWorldOrthographic__InstanceOnGameContentScaledEvent(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x5C06", Offset = "0x5C06", VA = "0x5C06")]
		public void SetSprite(Sprite sprite)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x5C07", Offset = "0x5C07", VA = "0x5C07")]
		public GameBgWorldOrthographic()
		{
		/* --- GHIDRA: .ctor ---
		void UI_GameBgWorldOrthographic___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a5b87c == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ImageAnimation__ShowAnimation_d__9_TypeInfo);
		    DAT_ram_00a5b87c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(UI_ImageAnimation__ShowAnimation_d__9_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x10")]
		private SpriteRenderer _spriteRenderer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SpriteRenderer ---
		void UI_GameBgWorldOrthographic__get_SpriteRenderer(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5b87a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_GameBgWorldOrthographic_InstanceOnGameContentScaledEvent__);
		    DAT_ram_00a5b87a = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  iVar3 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,Method_UI_GameBgWorldOrthographic_InstanceOnGameContentScaledEvent__,0
		            );
		  if (DAT_ram_00a5b80a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b80a = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x10);
		  while ((param1_02 = (int *)func_ii_7048(param1_00,param1_01,0), param1_02 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_02))) {
		    iVar2 = func_ii_4329(iVar3 + 0x10,param1_02,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
