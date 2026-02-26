using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;

namespace MVC
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000E3D")]
	public abstract class AbstractModel : IDisposable
	{
		// Token: 0x06005955 RID: 22869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005955")]
		[Address(RVA = "0xA696", Offset = "0xA696", VA = "0xA696", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005956")]
		[Address(RVA = "0xA697", Offset = "0xA697", VA = "0xA697")]
		public AbstractModel(UserData user)
		{
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005958 RID: 22872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001236")]
		public UserData User
		{
			[Token(Token = "0x6005957")]
			[Address(RVA = "0xA698", Offset = "0xA698", VA = "0xA698")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005958")]
			[Address(RVA = "0xA699", Offset = "0xA699", VA = "0xA699")]
			[CompilerGenerated]
			protected set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_User ---
		undefined4 MVC_AbstractModel__set_User(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x14),0x9e,0);
		  return uVar1;
		}
		*/

}
