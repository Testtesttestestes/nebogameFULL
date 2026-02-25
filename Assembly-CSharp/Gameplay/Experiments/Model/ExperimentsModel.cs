using System;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.Experiments.Model
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class ExperimentsModel : AbstractModel
	{
		// Token: 0x06003143 RID: 12611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x819B", Offset = "0x819B", VA = "0x819B")]
		public ExperimentsModel(UserData user)
		{
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x819C", Offset = "0x819C", VA = "0x819C")]
		public void SetExperiments(RepeatedField<ProtoGetUserExperimentsAns.Types.Experiment> experiments)
		{
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x819D", Offset = "0x819D", VA = "0x819D")]
		public bool TryGetExperimentGroup(uint experimentId, out uint group)
		{
			return default(bool);
		}

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0xC")]
		private readonly RepeatedField<ProtoGetUserExperimentsAns.Types.Experiment> _experiments;
	}
}
