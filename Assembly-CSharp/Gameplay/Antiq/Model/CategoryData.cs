using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Antiq.Model
{
	// Token: 0x02000D8F RID: 3471
	[Token(Token = "0x2000D8F")]
	internal class CategoryData
	{
		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060054EC RID: 21740 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x1700114A")]
		public uint SortOrder
		{
			[Token(Token = "0x60054EC")]
			[Address(RVA = "0xA292", Offset = "0xA292", VA = "0xA292")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x0000F528 File Offset: 0x0000D728
		[Token(Token = "0x1700114B")]
		public uint CategoryId
		{
			[Token(Token = "0x60054ED")]
			[Address(RVA = "0xA293", Offset = "0xA293", VA = "0xA293")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060054EE RID: 21742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EE")]
		[Address(RVA = "0xA294", Offset = "0xA294", VA = "0xA294")]
		public CategoryData(Antiq.Types.ArtifactGroupsDic.Types.CategoryDic categoryDic, string title)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Antiq_Model_CategoryData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 == 0) {
		    iVar1 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetDescription
		                      (*(undefined4 *)(param1 + 8),0);
		  }
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Gameplay_Antiq_Model_CategoryData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 == 0) {
		    iVar1 = Core_Extensions_Dict_Antiq_ArtifactGroupsDicExt__GetDescription
		                      (*(undefined4 *)(param1 + 8),0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x060054EF RID: 21743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054EF")]
		[Address(RVA = "0xA295", Offset = "0xA295", VA = "0xA295")]
		public CategoryData(Antiq.Types.ArtifactGroupsDic.Types.CategoryDic categoryDic)
		{
		}

		// Token: 0x060054F0 RID: 21744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60054F0")]
		[Address(RVA = "0xA296", Offset = "0xA296", VA = "0xA296")]
		public string GetTitle()
		{
			return null;
		}

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x8")]
		private readonly Antiq.Types.ArtifactGroupsDic.Types.CategoryDic _categoryDic;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _title;
	}
}
