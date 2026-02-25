using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	public class DollSkillRow : TitleIconValueBackground, IToolTipDataProvider
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x6478", Offset = "0x6478", VA = "0x6478")]
		public void Init(DollSkillDic dic)
		{
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x6479", Offset = "0x6479", VA = "0x6479")]
		public void Init(DollSkillDic dic, StoneDic stoneDic)
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x647A", Offset = "0x647A", VA = "0x647A", Slot = "6")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x647B", Offset = "0x647B", VA = "0x647B")]
		public DollSkillRow()
		{
		}

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x38")]
		private DollSkillDic _dic;
	}
}
