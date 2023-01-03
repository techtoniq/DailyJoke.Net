CREATE TABLE #TempJokes
(
	[Id] BIGINT IDENTITY,
	[Text] NVARCHAR(300)
)
 
INSERT INTO #TempJokes (Text)
VALUES
('I got a pair of mittens as my Secret Santa present at work. I think I know who they''re from, but I don''t want to point any fingers.'),
('My nephew downed a bottle of invisible ink earlier. He''s currently in A&E waiting to be seen.'),
('My mate is selling his Sooty and Sweep puppets. He''ll accept low ball offers just to get them off his hands.'),
('My mate who lost his leg in a motorbike accident has finally sorted his life out and found himself a job at the brewery. They''ve put him in charge of the hops.'),
('Somebody has glued my pack of playing cards together and I just can''t deal with it.'),
('I''ve got a new baby goat. It has a lopsided head. I''m going to name it ''Humphrey Bogart''. Ears looking askew, kid.'),
('I went to my local printer and said "I need a 2m high letter A, a 2m high letter S and a 2m high letter K, and I need them by tomorrow." He said, "I''ll see what I can do but it''s a big ask..."'),
('I''ve been nominated for the award of The World''s Most Secretive Person 2022. I can''t tell you what this means to me.'),
('Gloria Gaynor is holding a dinner party for six friends, but one has cancelled on her. She''s said it''s ok, she will serve five.'),
('Police have confirmed that the man who fell to his death from the roof of the Roxy Nightclub was not a bouncer.'),
('I''ve lost nearly half a stone on the new Adam and the Ants diet. It''s quite easy, you don''t chew ever, don''t chew everrrrr'),
('I''ve just bought a new laptop. Opened it up and it said "Hello". It''s a Dell.'),
('American sitcom DVDs are on the bookshelf, and the music magazines are on the coffee table. I like to keep my Friends close, but my NMEs closer.'),
('Did you know that Bill Withers son Bear writes hold music for phone systems?'),
('Craig David has joined the management team of the British Olympic Archery squad. He''s going to be the bow selector.'),
('Archaeologists at the British Museum had a party on Friday night to celebrate unearthing the largest ever dinosaur tibia. Apparently it was quite a shindig.'),
('I lost my job as a contortionist in the first Covid lockdown, and haven''t worked since. Now I''m struggling to make ends meet.'),
('I was watching Jurassic park earlier and I thought to myself... not only does my son have a terrible name but he''s rubbish at driving.'),
('I''ve spotted some fraudulent activity on my bank statement. Someone has been ordering boxes of aftershave using my details. The bank reckons my card has been cologned.'),
('I''m thinking of visiting the Haynes Motor Museum this weekend. Do you know if they have any automatics in there, or is it all just manuals?'),
('My mate Iain has one eye smaller than the other.'),
('I just asked Alexa to play Whatever You Want by Status Quo, so she played Rocking All Over the World.'),
('I went on a date last night with a girl who works at the zoo. It went really well. I think she''s a keeper.'),
('I''ve started a tribute band called Blanket. We''re just going to do covers.'),
('When the temperature suddenly dropped tonight I heard a ringing noise coming from the rear paddock. Sounded like tubular bells. Went out to investigate but it was just my cold field.'),
('Went to a Brit-Pop themed restaurant last night. Had Oasis Soup for starter - you got a roll with it.'),
('I''ve ordered Adam and the Ants sheet music from my local music shop and they said they will throw in a stand and deliver.'),
('I''ve just bought the world''s worst thesaurus. Not only is it terrible, it''s terrible.'),
('Elton John''s e-reader device has been blown away by Storm Francis. Like a Kindle in the wind.'),
('I''ve just made a ventriloquist dummy out of bits of old carpet. It''s ruggish.'),
('Was just watching Australian Masterchef and was surprised when the judges cheered applauded a contestants meringues, as Australians normally boo meringues.'),
('I''m considering running the London marathon next year. But getting all of those roads closed and making sure that there''s enough water for everyone is gonna be a nightmare.'),
('The CEO of Dulux Paints has died of hypothermia whilst on a team building exercise in Snowdonia. A Mountain Rescue spokesperson said he could have done with a second coat'),
('I''m currently out bird watching with Sinead O''Connor. So far, it''s been seven owls and fifteen jays.'),
('My friend told me he failed his Aboriginal music exam last week. So I asked him "did you re do it?"'),
('"Ok - Shaggy, Freddy, Daphne: name one of the top 5 largest African animals"\r\n"Rhino"\r\n"I''m sure you do Scooby but it''s not your turn"'),
('A vicar is in hospital after being injected with Dettol. Police have charged the suspect with bleach of the priest.'),
('A mate of mine works for Virgin Atlantic, but is currently furloughed. To give him an income I asked him if he''d like to decorate my house. He jumped at the chance. I must say he made a lovely job of the landing.'),
('The wife wanted to keep me occupied for Easter so suggested I make a bird table. Now she''s angry with me because I put her fifth.'),
('Just got back from Sainsbury''s. There was a bloke rushing round with 15kg of paella rice, 5 cases of tequila, 8 sombreros and 12 piñatas. I thought to myself, Hispanic buying.'),
('One of our neighbours was taken to hospital in the night with suspected Covid-19. I hear he’s been put on one of those new Dyson ventilators and is picking up nicely.'),
('Reports from Greece that they are running low on hummus and taramasalata are fuelling fears of a double dip recession.'),
('People in Germany are panic buying sausages and cheese. They’re looking at a Wurst Käse scenario.'),
('I met a bloke in the pub who only writes songs about sewing machines. He''s a Singer songwriter.'),
('I just turned down a contract for a role based in the Middle East. They tried to make me go to Riyadh and I said no, no, no.'),
('The inventor of the euphemism died today. His wife is taking it really hard.'),
('I just got stopped in the street by a Chinese drug addict. He said "have you seen my cocaine?" I said "not since he starred in The Italian Job"'),
('Sylvester Stallone has just released a new range of savoury scones. Don''t suppose you''ve tried them at all? Apparently they''re the best thing since Sly''s bread.'),
('Was just having a poo and ran out of toilet paper so had to do that trousers-round-the-ankles waddle to get some more. Got some funny looks in Tesco.'),
('Whilst on holiday in France Darth Vader goes in to a Boulangerie and orders three loaves of bread and two apple tarts. Or PAIN PAIN PAIN TARTE-TATIN, TARTE TATIN.'),
('The local chess club have hired some meeting rooms here and it must be break time cos they''re all in reception making a right old racket, showing off about some killer moves and generally bigging themselves up. If there''s one thing I can''t stand it''s chess nuts boasting in an open foyer.'),
('Went to see a bloody useless mind reader last night. She said "think of a card, any card" "OK" "Is it the four of clubs?" "No" "Ace of diamonds?" "No" "What is it then?" "Birthday"'),
('How long does it take a scouser to walk two tiny dogs around the park? Chihuahuas!'),
('Did you know that I come from a family of failed magicians? I’ve got two half sisters.'),
('Be careful if you’re thinking of getting a rescue cat. My nan had one. She slipped and fell yesterday and the cat literally sat there and did nothing.'),
('I was sitting drinking coffee in my slippers this morning, when I thought to myself...I really need to wash some mugs.'),
('Sky has full coverage of the Hairdresser of the Year awards. BBC are just showing the highlights.'),
('I lost my dog in the park last night. Was shouting his name for ages without any luck. Went home to check and the missus said I should try looking harder. So I shaved my head and got a tattoo but still couldn''t find him.')

SET IDENTITY_INSERT [dbo].[Jokes] ON;

MERGE [dbo].[Jokes] AS Target
USING #TempJokes AS Source
ON Source.Id = Target.Id
WHEN MATCHED THEN UPDATE SET
	Target.Text = Source.Text

WHEN NOT MATCHED By Target THEN
	INSERT (Id, Text, UsageCount) 
	VALUES (Source.Id, Source.Text, 0);

SET IDENTITY_INSERT [dbo].[Jokes] OFF;
DROP TABLE #TempJokes