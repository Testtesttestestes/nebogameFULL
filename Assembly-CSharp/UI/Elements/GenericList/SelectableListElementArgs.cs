using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public class SelectableListElementArgs : GenericListElementArgs
	{
		// Token: 0x140000ED RID: 237
		// (add) Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000ED")]
		public event Action<bool> SelectChangedEvent
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x607B", Offset = "0x607B", VA = "0x607B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x607C", Offset = "0x607C", VA = "0x607C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EE")]
		public event Action DataChangedEvent
		{
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x607D", Offset = "0x607D", VA = "0x607D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x607E", Offset = "0x607E", VA = "0x607E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x607F", Offset = "0x607F", VA = "0x607F")]
		public void CallDataChangedEvent()
		{
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00004128 File Offset: 0x00002328
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D2")]
		public bool Selected
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x6080", Offset = "0x6080", VA = "0x6080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x6081", Offset = "0x6081", VA = "0x6081")]
			set
			{
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x6082", Offset = "0x6082", VA = "0x6082")]
		public SelectableListElementArgs()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_GenericList_SelectableListElementArgs___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63985 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63985 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x24,param1_01,param1_00);
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

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0xC")]
		protected bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectChangedEvent ---
		void UI_Elements_GenericList_SelectableListElementArgs__add_SelectChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63982 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a63982 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectChangedEvent ---
		void UI_Elements_GenericList_SelectableListElementArgs__remove_SelectChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63983 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63983 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
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


		/* --- GHIDRA: add_DataChangedEvent ---
		void UI_Elements_GenericList_SelectableListElementArgs__add_DataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63984 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63984 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
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
