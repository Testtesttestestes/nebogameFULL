using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	public class ResourceSet_21 : AbstractTag
	{
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700090C")]
		public double[] ResourceSetArray
		{
			[Token(Token = "0x6002E9A")]
			[Address(RVA = "0x7F15", Offset = "0x7F15", VA = "0x7F15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x7F16", Offset = "0x7F16", VA = "0x7F16", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x7F17", Offset = "0x7F17", VA = "0x7F17")]
		public ResourceSet_21()
		{
		}

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		public const string RESOURCE_SET = "resource_set";
	}
}
