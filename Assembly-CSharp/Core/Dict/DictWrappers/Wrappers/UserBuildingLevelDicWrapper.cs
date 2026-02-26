using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Base;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;

namespace Core.Dict.DictWrappers.Wrappers
{
	// Token: 0x0200109A RID: 4250
	[Token(Token = "0x200109A")]
	public class UserBuildingLevelDicWrapper : AbstractDictWrapper<UserBuildingLevelDic, UserBuildingLevelDicWrapper.UserBuildingLevelDicWrapperId>
	{
		// Token: 0x060062D7 RID: 25303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60062D7")]
		[Address(RVA = "0xAEF6", Offset = "0xAEF6", VA = "0xAEF6", Slot = "7")]
		protected override UserBuildingLevelDic GetData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: GetData ---
		void Core_Dict_DictWrappers_Wrappers_UserBuildingLevelDicWrapper__GetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6074a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_UserBuildingLevelDic__UserBuildingLevelDicWrapper_UserBuildingLevelDicWrapperId___ctor__
		              );
		    DAT_ram_00a6074a = '\x01';
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060062D8 RID: 25304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062D8")]
		[Address(RVA = "0xAEF7", Offset = "0xAEF7", VA = "0xAEF7")]
		public UserBuildingLevelDicWrapper()
		{
		}

		// Token: 0x0200109B RID: 4251
		[Token(Token = "0x200109B")]
		public class UserBuildingLevelDicWrapperId
		{
			// Token: 0x170013B1 RID: 5041
			// (get) Token: 0x060062D9 RID: 25305 RVA: 0x00012960 File Offset: 0x00010B60
			// (set) Token: 0x060062DA RID: 25306 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013B1")]
			public UserBuildingTypes Type
			{
				[Token(Token = "0x60062D9")]
				[Address(RVA = "0xAEF8", Offset = "0xAEF8", VA = "0xAEF8")]
				[CompilerGenerated]
				get
				{
					return UserBuildingTypes.UnknownUserBuildingType;
				}
				[Token(Token = "0x60062DA")]
				[Address(RVA = "0xAEF9", Offset = "0xAEF9", VA = "0xAEF9")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170013B2 RID: 5042
			// (get) Token: 0x060062DB RID: 25307 RVA: 0x00012978 File Offset: 0x00010B78
			// (set) Token: 0x060062DC RID: 25308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013B2")]
			public uint Level
			{
				[Token(Token = "0x60062DB")]
				[Address(RVA = "0xAEFA", Offset = "0xAEFA", VA = "0xAEFA")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x60062DC")]
				[Address(RVA = "0xAEFB", Offset = "0xAEFB", VA = "0xAEFB")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060062DD RID: 25309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062DD")]
			[Address(RVA = "0xAEFC", Offset = "0xAEFC", VA = "0xAEFC")]
			public UserBuildingLevelDicWrapperId(UserBuildingTypes type, uint level)
			{
			}
		}
	}
}
