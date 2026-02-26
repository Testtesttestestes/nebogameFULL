using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	public class TileAndScrollEntitieDescription : MonoBehaviour
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x5C46", Offset = "0x5C46", VA = "0x5C46")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_TileAndScrollEntitieDescription__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5b89d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TMP_TextInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_TileAndScrollEntitieDescription_TextFieldOnOnPreRenderText__);
		    DAT_ram_00a5b89d = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_TMP_TextInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_UI_TileAndScrollEntitieDescription_TextFieldOnOnPreRenderText__
		             ,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x338) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x33c));
		  return;
		}
		*/

		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x5C47", Offset = "0x5C47", VA = "0x5C47")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_TileAndScrollEntitieDescription__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(param1 + 0x24) = 1;
		  return;
		}
		*/

		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x5C48", Offset = "0x5C48", VA = "0x5C48")]
		private void TextFieldOnOnPreRenderText(TMP_TextInfo obj)
		{
		/* --- GHIDRA: TextFieldOnOnPreRenderText ---
		void UI_TileAndScrollEntitieDescription__TextFieldOnOnPreRenderText(int *param1,undefined4 param2)
		
		{
		  if ((char)param1[9] != '\0') {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		    *(undefined1 *)(param1 + 9) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x5C49", Offset = "0x5C49", VA = "0x5C49")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void UI_TileAndScrollEntitieDescription__Update(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  float fVar2;
		  uint param2_00;
		  undefined1 auStack_10 [12];
		  float4 local_4;
		  
		  if ((*(uint *)(param1 + 0x1c) & 0x7fffffff) < 0x7f800001) {
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties
		              (auStack_10,*(undefined4 *)(param1 + 0x20),0);
		    fVar2 = *(float *)(param1 + 0x1c);
		    param1_00 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent
		                          (*(undefined4 *)(param1 + 0x10),0);
		    param2_00 = (uint)(fVar2 <= (float)local_4);
		    if (param2_00 == 0) {
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		      uVar1 = UnityEngine_UI_Selectable__set_interactable(uVar1,0);
		    }
		    else {
		      uVar1 = *(undefined4 *)(param1 + 0x18);
		    }
		    UnityEngine_Transform__GetParent(param1_00,uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x14),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x5C4A", Offset = "0x5C4A", VA = "0x5C4A", Slot = "4")]
		protected virtual void ValidateVisibleScroll()
		{
		/* --- GHIDRA: ValidateVisibleScroll ---
		void UI_TileAndScrollEntitieDescription__ValidateVisibleScroll(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = 0x7fc00000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x5C4B", Offset = "0x5C4B", VA = "0x5C4B")]
		public TileAndScrollEntitieDescription()
		{
		/* --- GHIDRA: .ctor ---
		void UI_TileAndScrollEntitieDescription___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b89e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToggleButton__TypeInfo);
		    DAT_ram_00a5b89e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ToggleButton__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ToggleButton__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _scrollView;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _scrollViewContent;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _maxHeight;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform _rectTransform;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x24")]
		private bool _isTextChanged;
	}
}
