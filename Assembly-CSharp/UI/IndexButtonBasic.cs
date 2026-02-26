using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Discounts.Model;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	public class IndexButtonBasic : MonoBehaviour, IDiscountTarget, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IGuideTargetResolveEventProvider
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FE")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x5BD3", Offset = "0x5BD3", VA = "0x5BD3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000FF")]
		public CanvasGroup CanvasGroup
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x5BD4", Offset = "0x5BD4", VA = "0x5BD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000C7 RID: 199
		// (add) Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000818 RID: 2072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C7")]
		public event Action<IndexButtonBasic> ClickEvent
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x5BD5", Offset = "0x5BD5", VA = "0x5BD5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x5BD6", Offset = "0x5BD6", VA = "0x5BD6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C8 RID: 200
		// (add) Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600081A RID: 2074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C8")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x5BD7", Offset = "0x5BD7", VA = "0x5BD7", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x5BD8", Offset = "0x5BD8", VA = "0x5BD8", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x5BD9", Offset = "0x5BD9", VA = "0x5BD9", Slot = "12")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x5BDA", Offset = "0x5BDA", VA = "0x5BDA", Slot = "13")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x5BDB", Offset = "0x5BDB", VA = "0x5BDB", Slot = "14")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000100")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x5BDC", Offset = "0x5BDC", VA = "0x5BDC", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x5BDD", Offset = "0x5BDD", VA = "0x5BDD", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x5BDE", Offset = "0x5BDE", VA = "0x5BDE")]
		public IndexButtonBasic()
		{
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x5BDF", Offset = "0x5BDF", VA = "0x5BDF", Slot = "11")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected Transform _discountWidget;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasGroup ---
		void UI_IndexButtonBasic__get_CanvasGroup(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b869 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    DAT_ram_00a5b869 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IndexButtonBasic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IndexButtonBasic__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: add_ClickEvent ---
		void UI_IndexButtonBasic__add_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b86a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    DAT_ram_00a5b86a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IndexButtonBasic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IndexButtonBasic__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_ClickEvent ---
		void UI_IndexButtonBasic__remove_ClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b86b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a5b86b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: add_ResolveEvent ---
		void UI_IndexButtonBasic__add_ResolveEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b86c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a5b86c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ResolveEvent ---
		void UI_IndexButtonBasic__remove_ResolveEvent(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = param1[8];
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = param1[9];
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x134));
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountTargets ---
		void UI_IndexButtonBasic__get_DiscountTargets(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5b86d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a5b86d = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  param2_00 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}
