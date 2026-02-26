using System;
using System.Collections.Generic;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Antiq
{
	// Token: 0x02000D7B RID: 3451
	[Token(Token = "0x2000D7B")]
	internal class AntiqEvents : AbstractMVCEvents
	{
		// Token: 0x0600548D RID: 21645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600548D")]
		[Address(RVA = "0xA240", Offset = "0xA240", VA = "0xA240")]
		public AntiqEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_AntiqEvents___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a5947a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Antiq_Launch_HandleInitEvent__);
		    DAT_ram_00a5947a = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) ||
		     (iVar2 = Cysharp_Threading_Tasks_UniTaskCompletionSource__MarkHandled
		                        (*(int *)(param1 + 0x14),0,0), iVar2 != 0)) {
		    iVar1 = *(int *)(param1 + 0xc);
		    param1_02 = *(undefined4 *)(iVar1 + 8);
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_Gameplay_Antiq_Launch_HandleInitEvent__,0);
		    param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		    iVar2 = System_Action_TypeInfo;
		    if (param1_01 == (int *)0x0) {
		      *(undefined4 *)(iVar1 + 8) = 0;
		    }
		    else if ((System_Action_TypeInfo != *param1_01) ||
		            (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		      System_Activator__CreateInstance(param1_01,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 8),0);
		  iVar2 = **(int **)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 8),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar2 + 0xec));
		  *(undefined1 *)(param1 + 0x18) = 1;
		  return;
		}
		*/

		}

		// Token: 0x04002DB6 RID: 11702
		[Token(Token = "0x4002DB6")]
		[FieldOffset(Offset = "0x14")]
		public Action GroupsChangedEvent;

		// Token: 0x04002DB7 RID: 11703
		[Token(Token = "0x4002DB7")]
		[FieldOffset(Offset = "0x18")]
		public Action<IList<GroupData>> AchievedGroupsChangedEvent;

		// Token: 0x04002DB8 RID: 11704
		[Token(Token = "0x4002DB8")]
		[FieldOffset(Offset = "0x1C")]
		public Action<GroupData> CurrentGroupChangedEvent;

		// Token: 0x04002DB9 RID: 11705
		[Token(Token = "0x4002DB9")]
		[FieldOffset(Offset = "0x20")]
		public Action<ArtifactData> CurrentArtifactChangedEvent;
	}
}
