using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Axis.Controller;
using Gameplay.Isles.Axis.Events;
using Gameplay.Isles.Axis.Model;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Isles.Axis
{
	// Token: 0x02000D01 RID: 3329
	[Token(Token = "0x2000D01")]
	public class AxisIsle : AbstractIsle<AxisIsleEvents, AxisIsleModel, AxisIsleController, AxisIsle.EmptyEnum>
	{
		// Token: 0x06005142 RID: 20802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005142")]
		[Address(RVA = "0x9F21", Offset = "0x9F21", VA = "0x9F21")]
		public AxisIsle(ulong id, UserData user, IGame game, IDictProvider dictProvider)
		{
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06005143 RID: 20803 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x17001076")]
		public override LocationTypes LocationType
		{
			[Token(Token = "0x6005143")]
			[Address(RVA = "0x9F22", Offset = "0x9F22", VA = "0x9F22", Slot = "10")]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x6005144")]
		[Address(RVA = "0x9F23", Offset = "0x9F23", VA = "0x9F23", Slot = "11")]
		public override bool TryOpenBuildingByType(uint type)
		{
			return default(bool);
		}

		// Token: 0x02000D02 RID: 3330
		[Token(Token = "0x2000D02")]
		public enum EmptyEnum
		{

		}
	}
}
