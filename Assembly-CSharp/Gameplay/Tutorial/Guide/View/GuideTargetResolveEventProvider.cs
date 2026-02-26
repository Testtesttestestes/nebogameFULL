using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	public class GuideTargetResolveEventProvider : MonoBehaviour, IGuideTargetResolveEventProvider
	{
		// Token: 0x1400012D RID: 301
		// (add) Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A79 RID: 6777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012D")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x6001A78")]
			[Address(RVA = "0x6C0F", Offset = "0x6C0F", VA = "0x6C0F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A79")]
			[Address(RVA = "0x6C10", Offset = "0x6C10", VA = "0x6C10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7A")]
		[Address(RVA = "0x6C11", Offset = "0x6C11", VA = "0x6C11")]
		public void Invoke()
		{
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A7B")]
		[Address(RVA = "0x6C12", Offset = "0x6C12", VA = "0x6C12")]
		public GuideTargetResolveEventProvider()
		{
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001A7C")]
		[Address(RVA = "0x6C13", Offset = "0x6C13", VA = "0x6C13", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ResolveEvent ---
		void Gameplay_Tutorial_Guide_View_GuideTargetResolveEventProvider__add_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58443 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a58443 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: Gameplay.Tutorial.Guide.View.IGuideTargetResolveEventProvider.get_gameObject ---
		void Gameplay_Tutorial_Guide_View_GuideTargetResolveEventProvider__Gameplay_Tutorial_Guide_View_IGuideTargetResolveEventProvider_get_gameObject
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58444 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTarget__TypeInfo);
		    DAT_ram_00a58444 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTarget__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTarget__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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
