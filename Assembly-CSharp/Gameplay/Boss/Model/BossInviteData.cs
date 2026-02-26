using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B92 RID: 2962
	[Token(Token = "0x2000B92")]
	public class BossInviteData
	{
		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x0600484D RID: 18509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600484E RID: 18510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA4")]
		public BackTime Backtime
		{
			[Token(Token = "0x600484D")]
			[Address(RVA = "0x96CD", Offset = "0x96CD", VA = "0x96CD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600484E")]
			[Address(RVA = "0x96CE", Offset = "0x96CE", VA = "0x96CE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x0600484F RID: 18511 RVA: 0x0000D608 File Offset: 0x0000B808
		// (set) Token: 0x06004850 RID: 18512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA5")]
		public ulong CaptainId
		{
			[Token(Token = "0x600484F")]
			[Address(RVA = "0x96CF", Offset = "0x96CF", VA = "0x96CF")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004850")]
			[Address(RVA = "0x96D0", Offset = "0x96D0", VA = "0x96D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06004851 RID: 18513 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004852 RID: 18514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA6")]
		[CanBeNull]
		public UserData CaptainUserData
		{
			[Token(Token = "0x6004851")]
			[Address(RVA = "0x96D1", Offset = "0x96D1", VA = "0x96D1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004852")]
			[Address(RVA = "0x96D2", Offset = "0x96D2", VA = "0x96D2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001C9 RID: 457
		// (add) Token: 0x06004853 RID: 18515 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004854 RID: 18516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C9")]
		public event Action CaptainUserDataChangedEvent
		{
			[Token(Token = "0x6004853")]
			[Address(RVA = "0x96D3", Offset = "0x96D3", VA = "0x96D3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004854")]
			[Address(RVA = "0x96D4", Offset = "0x96D4", VA = "0x96D4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004855 RID: 18517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x1B33", Offset = "0x1B33", VA = "0x1B33")]
		public BossInviteData(MercenaryInvitesEvt.Types.Invite invite)
		{
		}

		// Token: 0x06004856 RID: 18518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004856")]
		[Address(RVA = "0x96D5", Offset = "0x96D5", VA = "0x96D5")]
		private void ResultCallback(long operationIndex, UserData[] data)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CaptainUserData ---
		void Gameplay_Boss_Model_BossInviteData__set_CaptainUserData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57886 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57886 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
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


		/* --- GHIDRA: add_CaptainUserDataChangedEvent ---
		void Gameplay_Boss_Model_BossInviteData__add_CaptainUserDataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57887 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57887 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
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


		/* --- GHIDRA: remove_CaptainUserDataChangedEvent ---
		void Gameplay_Boss_Model_BossInviteData__remove_CaptainUserDataChangedEvent
		               (int param1,undefined8 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(param3 + 0x10);
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
