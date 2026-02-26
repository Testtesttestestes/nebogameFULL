using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AssetContent.Loaders
{
	// Token: 0x02000E35 RID: 3637
	[Token(Token = "0x2000E35")]
	[RequireComponent(typeof(PolygonCollider2D))]
	[DisallowMultipleComponent]
	public class GameSpriteRendererLoaderInteractable : GameSpriteRendererLoader, IPointerClickHandler, IEventSystemHandler, IBoundsProvider, IGrayscalable
	{
		// Token: 0x14000219 RID: 537
		// (add) Token: 0x0600591E RID: 22814 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600591F RID: 22815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000219")]
		public event Action ClickEvent
		{
			[Token(Token = "0x600591E")]
			[Address(RVA = "0xA671", Offset = "0xA671", VA = "0xA671")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600591F")]
			[Address(RVA = "0xA672", Offset = "0xA672", VA = "0xA672")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06005920 RID: 22816 RVA: 0x0000FD68 File Offset: 0x0000DF68
		// (set) Token: 0x06005921 RID: 22817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001228")]
		public bool Interactable
		{
			[Token(Token = "0x6005920")]
			[Address(RVA = "0xA673", Offset = "0xA673", VA = "0xA673")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005921")]
			[Address(RVA = "0x1DF9", Offset = "0x1DF9", VA = "0x1DF9")]
			set
			{
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06005922 RID: 22818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001229")]
		protected PolygonCollider2D PolygonCollider2D
		{
			[Token(Token = "0x6005922")]
			[Address(RVA = "0xA674", Offset = "0xA674", VA = "0xA674")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005923 RID: 22819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005923")]
		[Address(RVA = "0xA675", Offset = "0xA675", VA = "0xA675", Slot = "10")]
		protected override void HandleSpriteChanged()
		{
		/* --- GHIDRA: HandleSpriteChanged ---
		void AssetContent_Loaders_GameSpriteRendererLoaderInteractable__HandleSpriteChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005924 RID: 22820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005924")]
		[Address(RVA = "0xA676", Offset = "0xA676", VA = "0xA676", Slot = "12")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void AssetContent_Loaders_GameSpriteRendererLoaderInteractable__OnPointerClick
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63c06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Collider2D___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63c06 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_Collider2D___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param2,0);
		    uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_Renderer___);
		    UnityEngine_Renderer__set_useLightProbes(&local_18,uVar1,0);
		    param1[2] = local_8;
		    param1[1] = local_10;
		    *param1 = local_18;
		  }
		  else {
		    UnityEngine_Collider2D__set_offset(&local_18,uVar1,0);
		    param1[2] = local_8;
		    param1[1] = local_10;
		    *param1 = local_18;
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x1700122A")]
		public Bounds Bounds
		{
			[Token(Token = "0x6005925")]
			[Address(RVA = "0xA677", Offset = "0xA677", VA = "0xA677", Slot = "13")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005926")]
		[Address(RVA = "0xA678", Offset = "0xA678", VA = "0xA678")]
		public GameSpriteRendererLoaderInteractable()
		{
		}

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x38")]
		private PolygonCollider2D _polygonCollider2D;

		// Token: 0x04003020 RID: 12320
		[Token(Token = "0x4003020")]
		[FieldOffset(Offset = "0x3C")]
		private bool _interactable;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void AssetContent_Loaders_GameSpriteRendererLoaderInteractable__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63c03 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63c03 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x34,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Interactable ---
		undefined4
		AssetContent_Loaders_GameSpriteRendererLoaderInteractable__get_Interactable
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		    DAT_ram_00a63c04 = '\x01';
		  }
		  if (*(int *)(param1 + 0x38) != 0) {
		    return *(undefined4 *)(param1 + 0x38);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_PolygonCollider2D ---
		void AssetContent_Loaders_GameSpriteRendererLoaderInteractable__get_PolygonCollider2D
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63c05 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Vector2___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Vector2__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8775);
		    DAT_ram_00a63c05 = '\x01';
		  }
		  uVar1 = func_ii_7884(*(undefined4 *)(param1 + 0x2c),0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = func_ii_3812(uVar1,0,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a63c04 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		      DAT_ram_00a63c04 = '\x01';
		    }
		    if (*(int *)(param1 + 0x38) == 0) {
		      uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		      *(undefined4 *)(param1 + 0x38) = uVar1;
		    }
		    else {
		      uVar1 = *(undefined4 *)(param1 + 0x38);
		    }
		    uVar3 = unnamed_function_1417(System_Collections_Generic_List_Vector2__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar3,Method_System_Collections_Generic_List_Vector2___ctor__);
		    UnityEngine_PolygonCollider2D__SetPath_Internal(uVar1,0,uVar3,0);
		    return;
		  }
		  uVar1 = func_ii_7884(*(undefined4 *)(param1 + 0x2c),0);
		  iVar2 = UnityEngine_Sprite__get_uv(uVar1,0);
		  if (0 < iVar2) {
		    if (iVar2 != 1) {
		      uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_8775,*(undefined4 *)(param1 + 0x1c),StringLiteral_118,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar1,0);
		    }
		    uVar1 = unnamed_function_1417(System_Collections_Generic_List_Vector2__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar1,Method_System_Collections_Generic_List_Vector2___ctor__);
		    uVar3 = func_ii_7884(*(undefined4 *)(param1 + 0x2c),0);
		    UnityEngine_Sprite__GetPhysicsShapeCount(uVar3,0,uVar1,0);
		    if (DAT_ram_00a63c04 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		      DAT_ram_00a63c04 = '\x01';
		    }
		    if (*(int *)(param1 + 0x38) == 0) {
		      uVar3 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_PolygonCollider2D___);
		      *(undefined4 *)(param1 + 0x38) = uVar3;
		    }
		    else {
		      uVar3 = *(undefined4 *)(param1 + 0x38);
		    }
		    UnityEngine_PolygonCollider2D__SetPath_Internal(uVar3,0,uVar1,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Bounds ---
		void AssetContent_Loaders_GameSpriteRendererLoaderInteractable__get_Bounds
		               (int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x3c) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

}
