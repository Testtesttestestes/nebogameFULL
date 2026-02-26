using System;
using Core.MVC.Interfaces;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	public abstract class AbstractEventSectionView : MonoBehaviour
	{
		// Token: 0x06002C30 RID: 11312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x7CC0", Offset = "0x7CC0", VA = "0x7CC0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_EventView_AbstractEventSectionView__OnDestroy
		               (int *param1,undefined4 param2)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		            (param1,param1 + 4,param1[6],*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C31")]
		[Address(RVA = "0x7CC1", Offset = "0x7CC1", VA = "0x7CC1")]
		protected void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_GdEvents_View_EventView_AbstractEventSectionView__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (*(char *)(param1 + 0x14) == '\0') {
		    *(undefined1 *)(param1 + 0x14) = 1;
		    *(undefined4 *)(param1 + 0x18) = param2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C32")]
		[Address(RVA = "0x7CC2", Offset = "0x7CC2", VA = "0x7CC2")]
		public void Init(GdEventsController controller)
		{
		}

		// Token: 0x06002C33 RID: 11315
		[Token(Token = "0x6002C33")]
		protected abstract void CreateMediator(ref IViewMediator mediator, GdEventsController controller);

		// Token: 0x06002C34 RID: 11316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C34")]
		[Address(RVA = "0x7CC3", Offset = "0x7CC3", VA = "0x7CC3")]
		protected AbstractEventSectionView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_EventView_AbstractEventSectionView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a2aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a2aa = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
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

		}

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x10")]
		private IViewMediator _mediator;

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x14")]
		private bool _isInit;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x18")]
		private GdEventsController _controller;
	}
}
