using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DC RID: 4316
	[Token(Token = "0x20010DC")]
	public abstract class AbstractUserInformationProvider : AbstractInformationProvider
	{
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006513 RID: 25875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001475")]
		[NotNull]
		public UserData User
		{
			[Token(Token = "0x6006512")]
			[Address(RVA = "0xB0E8", Offset = "0xB0E8", VA = "0xB0E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006513")]
			[Address(RVA = "0xB0E9", Offset = "0xB0E9", VA = "0xB0E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006514")]
		[Address(RVA = "0xB0EA", Offset = "0xB0EA", VA = "0xB0EA", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Data_InfoRows_AbstractUserInformationProvider__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Data_InfoRows_AbstractInformationProvider__Dispose(param1,param3,0,param1);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006515")]
		[Address(RVA = "0xB0EB", Offset = "0xB0EB", VA = "0xB0EB")]
		protected AbstractUserInformationProvider([NotNull] UserData user, [NotNull] UserData loggedUser)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_User ---
		void Core_Data_InfoRows_AbstractUserInformationProvider__set_User(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (DAT_ram_00a60837 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Clear__);
		    DAT_ram_00a60837 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 8);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

}
