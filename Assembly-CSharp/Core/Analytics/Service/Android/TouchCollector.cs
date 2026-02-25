using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Core.Analytics.Service.Android
{
	// Token: 0x02001297 RID: 4759
	[Token(Token = "0x2001297")]
	internal class TouchCollector
	{
		// Token: 0x06007118 RID: 28952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007118")]
		[Address(RVA = "0xBB3F", Offset = "0xBB3F", VA = "0xBB3F")]
		public TouchCollector()
		{
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007119")]
		[Address(RVA = "0xBB40", Offset = "0xBB40", VA = "0xBB40")]
		public string StopCollect()
		{
			return null;
		}

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600711A RID: 28954 RVA: 0x00014838 File Offset: 0x00012A38
		// (set) Token: 0x0600711B RID: 28955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001704")]
		public bool IsActive
		{
			[Token(Token = "0x600711A")]
			[Address(RVA = "0xBB41", Offset = "0xBB41", VA = "0xBB41")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600711B")]
			[Address(RVA = "0xBB42", Offset = "0xBB42", VA = "0xBB42")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711C")]
		[Address(RVA = "0x1E69", Offset = "0x1E69", VA = "0x1E69")]
		public void Began(int touchId, Vector2 position)
		{
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711D")]
		[Address(RVA = "0x1E68", Offset = "0x1E68", VA = "0x1E68")]
		public void Moved(int touchId, Vector2 position)
		{
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600711E")]
		[Address(RVA = "0x1E6C", Offset = "0x1E6C", VA = "0x1E6C")]
		public void Ended(int touchId)
		{
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x600711F")]
		[Address(RVA = "0xBB43", Offset = "0xBB43", VA = "0xBB43")]
		private Vector2 ConvertToViewPosition(Vector2 position)
		{
			return default(Vector2);
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x6007120")]
		[Address(RVA = "0xBB44", Offset = "0xBB44", VA = "0xBB44")]
		private long GetTimestamp()
		{
			return 0L;
		}

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		private const float MoveThreshold = 0.01f;

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<int, TouchCollector.TapInfoRecord> _activeTaps;

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<TouchCollector.TapInfoRecord> _tapsArchive;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		[FieldOffset(Offset = "0x10")]
		private readonly DateTime _startTime;

		// Token: 0x02001298 RID: 4760
		[Token(Token = "0x2001298")]
		private class TapPhaseRecord
		{
			// Token: 0x17001705 RID: 5893
			// (get) Token: 0x06007121 RID: 28961 RVA: 0x00014880 File Offset: 0x00012A80
			[Token(Token = "0x17001705")]
			public TouchPhase Phase
			{
				[Token(Token = "0x6007121")]
				[Address(RVA = "0xBB45", Offset = "0xBB45", VA = "0xBB45")]
				[CompilerGenerated]
				get
				{
					return TouchPhase.None;
				}
			}

			// Token: 0x17001706 RID: 5894
			// (get) Token: 0x06007122 RID: 28962 RVA: 0x00014898 File Offset: 0x00012A98
			[Token(Token = "0x17001706")]
			public Vector2 Position
			{
				[Token(Token = "0x6007122")]
				[Address(RVA = "0xBB46", Offset = "0xBB46", VA = "0xBB46")]
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17001707 RID: 5895
			// (get) Token: 0x06007123 RID: 28963 RVA: 0x000148B0 File Offset: 0x00012AB0
			[Token(Token = "0x17001707")]
			public long Timestamp
			{
				[Token(Token = "0x6007123")]
				[Address(RVA = "0xBB47", Offset = "0xBB47", VA = "0xBB47")]
				[CompilerGenerated]
				get
				{
					return 0L;
				}
			}

			// Token: 0x06007124 RID: 28964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007124")]
			[Address(RVA = "0xBB48", Offset = "0xBB48", VA = "0xBB48")]
			public TapPhaseRecord(TouchPhase phase, Vector2 position, long timestamp)
			{
			}

			// Token: 0x06007125 RID: 28965 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007125")]
			[Address(RVA = "0xBB49", Offset = "0xBB49", VA = "0xBB49", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		// Token: 0x02001299 RID: 4761
		[Token(Token = "0x2001299")]
		private class TapInfoRecord
		{
			// Token: 0x17001708 RID: 5896
			// (get) Token: 0x06007126 RID: 28966 RVA: 0x000148C8 File Offset: 0x00012AC8
			[Token(Token = "0x17001708")]
			[JsonProperty("id")]
			public int Id
			{
				[Token(Token = "0x6007126")]
				[Address(RVA = "0xBB4A", Offset = "0xBB4A", VA = "0xBB4A")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001709 RID: 5897
			// (get) Token: 0x06007127 RID: 28967 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001709")]
			[JsonProperty("p")]
			public string[] Phases
			{
				[Token(Token = "0x6007127")]
				[Address(RVA = "0xBB4B", Offset = "0xBB4B", VA = "0xBB4B")]
				get
				{
					return null;
				}
			}

			// Token: 0x06007128 RID: 28968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007128")]
			[Address(RVA = "0xBB4C", Offset = "0xBB4C", VA = "0xBB4C")]
			public TapInfoRecord(int tapId, long timestamp, Vector2 position)
			{
			}

			// Token: 0x06007129 RID: 28969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007129")]
			[Address(RVA = "0x1E64", Offset = "0x1E64", VA = "0x1E64")]
			public void AddPhase(TouchPhase phase, long timestamp, Vector2? position)
			{
			}

			// Token: 0x04003B0B RID: 15115
			[Token(Token = "0x4003B0B")]
			[FieldOffset(Offset = "0x8")]
			private readonly List<TouchCollector.TapPhaseRecord> _phases;
		}
	}
}
