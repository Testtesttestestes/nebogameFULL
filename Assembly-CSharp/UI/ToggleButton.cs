using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	public class ToggleButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x140000CD RID: 205
		// (add) Token: 0x060008C0 RID: 2240 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008C1 RID: 2241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CD")]
		public event Action<ToggleButton> ClickEvent
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x5C4C", Offset = "0x5C4C", VA = "0x5C4C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x5C4D", Offset = "0x5C4D", VA = "0x5C4D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00003588 File Offset: 0x00001788
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public bool Selected
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x5C4E", Offset = "0x5C4E", VA = "0x5C4E")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x5C4F", Offset = "0x5C4F", VA = "0x5C4F")]
			set
			{
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x5C50", Offset = "0x5C50", VA = "0x5C50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x5C51", Offset = "0x5C51", VA = "0x5C51", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_ToggleButton__OnPointerClick(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5b8a0 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x3f8ccccd3f8ccccd;
		  local_18 = 0x3f8ccccd3f8ccccd;
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_18,0.15,0);
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x5C52", Offset = "0x5C52", VA = "0x5C52", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerEnter ---
		void UI_ToggleButton__OnPointerEnter(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5b8a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a5b8a1 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  uVar1 = System_Collections_Generic_Queue_object___Dequeue(uVar1,&local_10,0.4,0);
		  DG_Tweening_ShortcutExtensions__DOScale
		            (uVar1,6,
		             Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		            );
		  return;
		}
		*/

		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x5C53", Offset = "0x5C53", VA = "0x5C53", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x5C54", Offset = "0x5C54", VA = "0x5C54")]
		public ToggleButton()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToggleButton___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  UnityEngine_Transform___ctor(&local_c,param2_00,0);
		  *(undefined4 *)(param1 + 0x20) = local_4;
		  *(undefined8 *)(param1 + 0x18) = local_c;
		  return;
		}
		*/

		}

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _image;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Sprite _spriteDefault;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _spriteSelected;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x1C")]
		private bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void UI_ToggleButton__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b89f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToggleButton__TypeInfo);
		    DAT_ram_00a5b89f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: get_Selected ---
		void UI_ToggleButton__get_Selected(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *(char *)(param1 + 0x1c) = (char)param2;
		  iVar1 = 0x18;
		  if (param2 == 0) {
		    iVar1 = 0x14;
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + iVar1),0);
		  return;
		}
		*/

}
