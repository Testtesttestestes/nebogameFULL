using System;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x0200066A RID: 1642
	[Token(Token = "0x200066A")]
	public class ArtifactInfoPropertiesView : MonoBehaviour
	{
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078C")]
		public ArtifactInfoProvider InfoProvider
		{
			[Token(Token = "0x60027E3")]
			[Address(RVA = "0x7909", Offset = "0x7909", VA = "0x7909")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027E4")]
			[Address(RVA = "0x790A", Offset = "0x790A", VA = "0x790A")]
			set
			{
			}
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x790B", Offset = "0x790B", VA = "0x790B")]
		private void HandleInfoProviderChanged()
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x790C", Offset = "0x790C", VA = "0x790C")]
		public void ResetInfo()
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x790D", Offset = "0x790D", VA = "0x790D")]
		public ArtifactInfoPropertiesView()
		{
		}

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactInformationBox _artifactinfoBox;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0x14")]
		private ArtifactInfoProvider _infoProvider;
	}
}
